using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain;
using UserApp.Domain.Interfaces;

namespace UserApp.Core.Interfaces
{
    public interface IUserBusinessLogic
    {

        Task<Tuple<AuthenticationStatus, User>> SignIn(string email, string password);
    }
}
