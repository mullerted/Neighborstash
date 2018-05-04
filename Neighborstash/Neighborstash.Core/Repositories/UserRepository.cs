using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neighborstash.Core.Model;

namespace Neighborstash.Core.Contracts
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        // mock all users
        public List<User> AllUsers { get; set; }

        public UserRepository()
        {
            AllUsers = new List<User>
            {
                new User{ UserId = 1, Firstname = "Ted", Lastname = "Miller"},
                new User{UserId = 2, Firstname = "Tedx", Lastname = "Millerx"},
                new User{UserId = 3, Firstname = "Tedy", Lastname = "Millery"}
            };
        }
    

    public async Task<List<User>> GetAllUsers()
        {
            return await Task.FromResult(AllUsers);
        }

        public async Task<User> GetUserById(int id)
        {
            return await Task.FromResult(AllUsers.FirstOrDefault(u=>u.UserId == id) );
        }

        public async Task<User> GetUserById(string username)
        {
            return await Task.FromResult(AllUsers.FirstOrDefault(u => u.Username == username));
        }
    }


}
