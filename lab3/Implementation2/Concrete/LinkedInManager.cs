using Laboratory3.Implementation2.Interfaces;

namespace Laboratory3.Implementation2.Concrete
{
    public class LinkedInManager : ISocialManager
    {
        private bool _isAuthorized;

        public bool Authorize(string email, string password)
        {
            //TODO: change to real implementation
            _isAuthorized = !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password);
            return _isAuthorized;
        }

        public string PostMessage(string message)
        {
            if (!_isAuthorized) throw new Exception("Not Authorized");

            //TODO: post message to Facebook
            return $"Message posted to LinedIn: {message}";
        }
    }
}
