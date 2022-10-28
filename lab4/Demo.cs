using Laboratory4.Concrete;
using Laboratory4.Interfaces;

namespace Laboratory4
{
    public class Demo
    {
        private const string LOGIN = "login";
        private const string EMAIL = "email@gmail.com";
        private const string SLACK_API_KEY = "key";

        public void Run()
        {
            var message = "Hello World!";

            var emailNotification = new EmailNotification(EMAIL);
            SendMessage(emailNotification, "title", message);

            var slack = new Slack();
            var slackAdapter = new SlackAdapter(slack);
            slackAdapter.Authorize(LOGIN, SLACK_API_KEY);
            slackAdapter.SetChatId("chatId");
            SendMessage(slackAdapter, "", message);

            var sms = new Sms();
            var smsAdapter = new SmsAdapter(sms);
            smsAdapter.SetSenderNumber("+38(050)123-45-67");
            smsAdapter.SetRecepientNumber("+38(066)987-65-43");
            SendMessage(smsAdapter, "", message);
        }

        private void SendMessage(INotification notification, string title, string message)
        {
            notification.Send(title, message);
        }
    }
}
