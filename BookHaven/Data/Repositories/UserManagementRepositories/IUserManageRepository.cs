using BookHaven.Data.Models;
using System.Collections.Generic;

namespace BookHaven.Data.Repositories
{
    internal interface IUserManageRepository
    {
        void AddUser(UserModel user);
        List<KeyValuePair<int, string>> GetUserRoles();

        List<UserModel> GetAllUsers();
        void UpdateUser(UserModel user);
        void DeleteUser(int userId); // Add this method signature
    }
}
