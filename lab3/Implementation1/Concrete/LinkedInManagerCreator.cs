using Laboratory3.Implementation1.Abstract;
using Laboratory3.Implementation1.Interfaces;

namespace Laboratory3.Implementation1.Concrete
{
    public class LinkedInManagerCreator : SocialManagerCreator
    {
        public override ISocialManager FactoryMethod(string email, string password)
        {
             return new LinkedInManager(email, password);
        }

        public LinkedInManagerCreator(string username, string password) : base(username, password)
        {
        }
    }
}
