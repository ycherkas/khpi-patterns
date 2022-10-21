using Laboratory3.Implementation1.Abstract;
using Laboratory3.Implementation1.Interfaces;

namespace Laboratory3.Implementation1.Concrete
{
    public class FacebookManagerCreator : SocialManagerCreator
    {
        public override ISocialManager FactoryMethod(string username, string password)
        {
            return new FacebookManager(username, password);
        }

        public FacebookManagerCreator(string username, string password) : base(username, password)
        {
        }
    }
}
