using Laboratory4.Interfaces;

namespace Laboratory4.Concrete
{
    public class EmailNotification : INotification
    {
        private string _adminEmail;

        public void Send(string title, string message)
        {
            //TODO: implement
            var logMessage = $"Sent email with title '${title}' to '${_adminEmail} that says '${message}'";
        }

        public EmailNotification(string adminEmail)
        {
            _adminEmail = adminEmail;
        }
    }
}
