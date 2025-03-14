using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Business.Interfaces
{
    public interface IAuthService
    {
        UserModel AuthenticateUser(string email, string password);
    }
}
