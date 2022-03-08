using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using AutoMapper;
using DAL;

namespace BLL
{
    public class AuthService
    {
        static AuthService()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();
                c.CreateMap<Employee, EmployeeModel>();
                c.CreateMap<EmployeeModel, Employee>();
            });
            var mapper = new Mapper(config);
        }
        public static TokenModel Authenticate(UserModel user)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserModel>();
                c.CreateMap<UserModel, User>();
                c.CreateMap<Employee, EmployeeModel>();
                c.CreateMap<EmployeeModel, Employee>();
                c.CreateMap<Token, TokenModel>();
                c.CreateMap<TokenModel, Token>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<User>(user);
            var result=DataAccessFactory.AuthDataAccess().Authenticate(data);
            var token = mapper.Map<TokenModel>(result);
            return token;
        }
        public static bool IsAuthenticated(string token)
        {
            var rs=DataAccessFactory.AuthDataAccess().IsAuthenticated(token);
            return rs;
        }
        public static bool Logout(string token)
        {
            return DataAccessFactory.AuthDataAccess().logout(token);
        }
    }
}
