using Laboratory4.Interfaces;

namespace Laboratory4.Concrete
{
    public class SlackAdapter: INotification
    {
        private Slack _slack;
        private string _chatId;

        public void Send(string title, string message)
        {
            _slack.SendMessage(_chatId, message);
        }

        public void Authorize(string login, string apiKey)
        {
            _slack.Authorize(login, apiKey);
        }

        public void SetChatId(string chatId)
        {
            _chatId = chatId;
        }

        public SlackAdapter(Slack slack)
        {
            _slack = slack;
        }
    }
}
