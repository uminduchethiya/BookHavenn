using BookHaven.Data.Models;
using System.Collections.Generic;

namespace BookHaven.Business.Interfaces
{
    public interface IUserService
    {
        void AddUser(UserModel user);
        List<KeyValuePair<int, string>> GetUserRoles();
        List<UserModel> GetAllUsers();
        void UpdateUser(UserModel user);
        void DeleteUser(int userId); // Add this line
    }
}
