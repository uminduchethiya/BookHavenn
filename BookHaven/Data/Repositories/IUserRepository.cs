using BookHaven.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Repositories
{
    public interface IUserRepository
    {
        UserModel GetUserByEmailAndPassword(string email, string password);


    }



}

