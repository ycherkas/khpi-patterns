using Laboratory3.Implementation1.Interfaces;

namespace Laboratory3.Implementation1.Abstract
{
    public abstract class SocialManagerCreator
    {
        private string _username;
        private string _password;

        public abstract ISocialManager FactoryMethod(string username, string password);

        public string PostMessage(string message)
        {
            var manager = FactoryMethod(_username, _password);

            return manager.PostMessage(message);
        }

        public SocialManagerCreator(string username, string password)
        {
            _username = username;
            _password = password;
        }
    }
}
