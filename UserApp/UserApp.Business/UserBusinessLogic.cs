using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Core.Interfaces;
using UserApp.Domain;
using UserApp.Domain.Interfaces;
using UserApp.Repository;

namespace UserApp.Core
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IContext context;

        public UserBusinessLogic(IContext context)
        {
            this.context = context;
        }

        public async Task<Tuple<AuthenticationStatus,User>> SignIn(string email, string password)
        {
            var status = AuthenticationStatus.Invalid;

            var user = await context.Users.FirstOrDefaultAsync(item => item.Email == email && item.Password == password);

            if (user != null)
                status = AuthenticationStatus.Valid;

            return new Tuple<AuthenticationStatus, User>(status, user);

        }
    }
}
