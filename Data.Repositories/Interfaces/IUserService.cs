using Data.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Services.Interfaces
{
    public interface IUserService
    {
        public string Register(RegisterModel model);
        public string Login(LoginModel model);
    }
}
