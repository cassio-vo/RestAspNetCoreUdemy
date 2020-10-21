using RestAspNetCoreUdemy_Verbos.Model;
using RestAspNetCoreUdemy_Verbos.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNetCoreUdemy_Verbos.Repository.Implementations
{
    public class UserRepositoryImp : IUserRepository
    {
        private readonly MySqlContext _context;

        public UserRepositoryImp(MySqlContext context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(u => u.Login.Equals(login));
        }
    }
}
