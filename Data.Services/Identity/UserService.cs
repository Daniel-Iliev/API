using Data.AppDBContext;
using Data.Models.Models;
using Data.Services.Dto;
using Data.Services.Interfaces;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;

namespace Data.Services.Identity
{
    public class UserService : IUserService
    {
        private DBContext applicationDb;

        public UserService(DBContext dbContext)
        {
            applicationDb = dbContext;
        }
        public string ChangeUsername(string username, string newUsername)
        {
            using (applicationDb)
            {

                var findUser = applicationDb.Users.FirstOrDefault(x => x.Username == username);
                var role = findUser.Role;
                if (findUser != null)
                {

                    findUser.Username = newUsername;
                    findUser.ModifiedAt = DateTime.Now;
                    applicationDb.SaveChanges();
                    var token = TokenGenerator(newUsername,role);
                    return token;
                }
                return "Invalid User";

            }
        }

        public string ChangePassword(string username,ChangePassword changePassword)
        {
            using (applicationDb)
            {

                var findUser = applicationDb.Users.FirstOrDefault(x => x.Username == username);
                if (findUser != null)
                {
                    if (Hash(changePassword.OldPassword)==findUser.Password) {
                        findUser.Password = Hash(changePassword.NewPassword);
                        findUser.ModifiedAt = DateTime.Now;
                        applicationDb.SaveChanges();
                        return "Password has been changed";
                    }
                    return "Wrong Password";
                    
                }
                return "Invalid token";

            }
        }
        public string Login(LoginModel model)
        {
            using (applicationDb)
            {
                var user = applicationDb.Users.FirstOrDefault(x => x.Username == model.Username);
                var role = user.Role;
                if (user != null)
                {
                    if (user.Password == Hash(model.Password))
                    {
                        var token = TokenGenerator(model.Username,role);

                        return token;
                    }
                }
                return "Invalid User" ;
            }
        }

        public string Register(RegisterModel model)
        {
            try
            {
                using (applicationDb)
                {
                    if (applicationDb.Users.FirstOrDefault(x => x.Username == model.Username) == null)
                    {
                        bool passwordValidation = CheckUserPassword(model);
                        if (passwordValidation == true)
                        {
                            string hashedPassword = Hash(model.Password);
                            applicationDb.Users.Add(new User()
                            {
                                Username = model.Username,
                                Password = hashedPassword,
                                Role = "User"
                            });
                            applicationDb.SaveChanges();
                            return TokenGenerator(model.Username,"User");
                        }

                        return "Invalid Password";
                    }
                    return "Username already exists";
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private string TokenGenerator(string username,string role)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string file = Path.Combine(path, "tokenconfig.json");
            string salt;
            string issuer;
            string audience;
            double accessExpiration;

            using (StreamReader sr = new StreamReader(file))
            {
                string content = sr.ReadToEnd();
                JObject jsonObject = (JObject)JsonConvert.DeserializeObject(content);
                salt = jsonObject["secret"].Value<string>();
                issuer = jsonObject["Issuer"].Value<string>();
                audience = jsonObject["audience"].Value<string>();
                accessExpiration = jsonObject["AccessExpiration"].Value<double>();

            }
            var claim = new List<Claim>()
                                {
                                  new Claim(ClaimTypes.Name,username),
                                  new Claim(ClaimTypes.Role,role)
                                };


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(salt));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                issuer,
                audience,
                claim,
                expires: DateTime.Now.AddMinutes(accessExpiration),
                signingCredentials: credentials
            );
            string token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return token;
        }
        private string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        private bool CheckUserPassword(RegisterModel model)
        {
            bool result =
                           model.Password.Any(c => char.IsLetter(c)) &&
                           model.Password.Any(c => char.IsDigit(c));
            if (result == true)
            {
                if (model.Password == model.ConfirmPassword)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        
    }
}
