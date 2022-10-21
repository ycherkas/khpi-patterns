using Laboratory3.Implementation1.Abstract;
using Laboratory3.Implementation1.Concrete;

namespace Laboratory3.Implementation1
{
    public class Demo
    {
        private const string LOGIN = "login";
        private const string EMAIL = "test@gmail.com";
        private const string PASSWORD = "password";

        public void Run()
        {
            var facebookManagerCreator = new FacebookManagerCreator(LOGIN, PASSWORD);
            var linkedInManagerCreator = new LinkedInManagerCreator(EMAIL, PASSWORD);

            PostMessage(facebookManagerCreator, "New Message to Facebook");
            PostMessage(linkedInManagerCreator, "New Message to LinkedIn");
        }

        public string PostMessage(SocialManagerCreator creator, string message)
        {
            return creator.PostMessage(message);
        }
    }
}