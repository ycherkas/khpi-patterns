namespace Laboratory3.Implementation2.Interfaces
{
    public interface ISocialManager
    {
        bool Authorize(string username, string password);

        string PostMessage(string message);
    }
}
