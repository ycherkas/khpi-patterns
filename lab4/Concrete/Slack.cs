namespace Laboratory4.Concrete
{
    public class Slack
    {
        private bool _isAuthorized;

        public void Authorize(string login, string apiKey)
        {
            _isAuthorized = !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(apiKey);
        }

        public void SendMessage(string chatId, string message)
        {
            if (!_isAuthorized) throw new Exception("Not Authorized");

            //TODO: implement
        }
    }
}
