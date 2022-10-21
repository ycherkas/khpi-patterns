using Laboratory3.Implementation2.Concrete;

namespace Laboratory3.Implementation2
{
    public class Demo
    {
        private const string LOGIN = "login";
        private const string EMAIL = "test@gmail.com";
        private const string PASSWORD = "password";

        public void Run()
        {
            var facebookManager = Factory.Get(SocialNetworkType.Facebook);
            facebookManager.Authorize(LOGIN, PASSWORD);
            facebookManager.PostMessage("New Message to Facebook");

            var linkedInManager = Factory.Get(SocialNetworkType.LinkedIn);
            linkedInManager.Authorize(EMAIL, PASSWORD);
            linkedInManager.PostMessage("New Message to LinkedIn");
        }
    }
}