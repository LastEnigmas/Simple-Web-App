using Microsoft.AspNetCore.Mvc;
using SocialMediaWeb.Services.UserServices;
using SocialMediaWeb.ViewModels;
using System.Drawing;

namespace SocialMediaWeb.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Show()
        {
            var users = await _userService.GetAllUser();
            List<UserViewModels> usersViewModels = new List<UserViewModels>();
            foreach (var user in users)
            {
                var userViewModel = new UserViewModels()
                {
                    Id = user.Id,
                    UserImgName = user.Image,
                    UserAddress = user.Address,
                    Username = user.Username,
                };

                usersViewModels.Add(userViewModel);
            }

            return View(usersViewModels);

        }
    }
}
