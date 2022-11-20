using Microsoft.EntityFrameworkCore;
using SocialMediaWeb.Data;
using SocialMediaWeb.Helper;
using SocialMediaWeb.Models;
using SocialMediaWeb.ViewModels;

namespace SocialMediaWeb.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly MyDbWeb _db;
        public UserService(MyDbWeb db)
        {
            _db = db;
        }

        public bool Add(User user)
        {
            _db.Users.Add(user);
            return Save();   
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _db.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public bool Save()
        {
            var saved = _db.SaveChanges();
            return  saved > 0 ? true : false;
        }
    }
}
