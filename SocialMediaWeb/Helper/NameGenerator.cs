namespace SocialMediaWeb.Helper
{
    public class NameGenerator
    {
        public static string GeneraitorUniqCode()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
