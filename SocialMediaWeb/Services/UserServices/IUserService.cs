using SocialMediaWeb.Models;
using SocialMediaWeb.ViewModels;

namespace SocialMediaWeb.Services.UserServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUser();
        Task<User> GetUserById(int id);
        bool Save();
        bool Add(User user);
    }
}
