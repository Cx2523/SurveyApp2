using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;

namespace ClassLibrary.Data.Repositories
{
    interface IUserRepository
    {
        //IEnumerable<User> GetUsers();
        //User GetUserById(int UserId);
        User GetUserByUsernameAndEmail(string username, string email);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int UserId);
        void Save();
    }
}
