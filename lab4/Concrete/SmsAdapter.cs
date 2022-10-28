using Laboratory4.Interfaces;

namespace Laboratory4.Concrete
{
    public class SmsAdapter: INotification
    {
        private Sms _sms;
        private string _senderPhoneNumber;
        private string _recepientPhoneNumber;

        public void Send(string title, string message)
        {
            if (string.IsNullOrEmpty(_senderPhoneNumber)) throw new ArgumentNullException("Sender phone number is required");

            if (string.IsNullOrEmpty(_recepientPhoneNumber)) throw new ArgumentNullException("Recepient phone number is required");

            _sms.SendSms(_senderPhoneNumber, _recepientPhoneNumber, message);
        }

        public void SetSenderNumber(string number)
        {
            _senderPhoneNumber = number;
        }

        public void SetRecepientNumber(string number)
        {
            _recepientPhoneNumber = number;
        }

        public SmsAdapter(Sms sms)
        {
            _sms = sms;
        }
    }
}
