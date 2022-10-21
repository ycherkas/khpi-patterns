using Laboratory3.Implementation1.Interfaces;

namespace Laboratory3.Implementation1.Concrete
{
    public class FacebookManager : ISocialManager
    {
        private bool _isAuthorized;

        private bool Authorize(string login, string password)
        {
            //TODO: change to real implementation
            _isAuthorized = !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password);
            return _isAuthorized;
        }

        public string PostMessage(string message)
        {
            if (!_isAuthorized) throw new Exception("Not Authorized");

            //TODO: post message to Facebook
            return $"Message posted to Facebook: {message}";
        }

        public FacebookManager(string login, string password)
        {
            Authorize(login, password);
        }
    }
}
