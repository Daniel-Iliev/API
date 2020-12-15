using Data.Services.Dto;

namespace Data.Services.Interfaces
{
    public interface IUserService
    {
        public string Register(RegisterModel model);
        public string Login(LoginModel model);
    }
}
