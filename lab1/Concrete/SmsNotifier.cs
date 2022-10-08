using Laboratory1.Interfaces;

namespace Laboratory1.Concrete
{
    public class SmsNotifier : INotifier
    {
        public void Notify(string message, User recipient)
        {
            //TODO: notify recipient via SMS
        }
    }
}
