using SocialMediaWeb.Models;

namespace SocialMediaWeb.ViewModels
{
    public class UserViewModels
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UserImgName { get; set; }
        public Address UserAddress { get; set; }
    }
}
