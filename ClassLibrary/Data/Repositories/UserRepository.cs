using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        // the User Repository would be basically an admin layer over
        // the standard User interface. for now it is just stubbed 
        // except to get a specific User based on username and email.
        private Context _context = null;
        public UserRepository(Context context)
        {
            _context = context; 
        }

        //public IEnumerable<User> GetUsers() { }

        //public User GetUserById(int id) { } 

        public User GetUserByUsernameAndEmail(string username, string email)
        {
            
            return _context.Users
                .Where(user => user.Username == username && user.Email == email)
                .Include(user => user.Clients)
                .Include(user => user.Questions)
                .Include(user => user.Surveys)
                .SingleOrDefault();
        }

        public void InsertUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user) { }

        public void DeleteUser(int UserId) { }

        public void Save() { }
    }
}
