using Laboratory3.Implementation2.Interfaces;

namespace Laboratory3.Implementation2.Concrete
{
    public class Factory
    {
        public static ISocialManager Get(SocialNetworkType type)
        {
            switch(type)
            {
                case SocialNetworkType.Facebook:
                    return new FacebookManager();
                case SocialNetworkType.LinkedIn:
                    return new LinkedInManager();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
