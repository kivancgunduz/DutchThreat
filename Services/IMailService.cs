namespace DutchThreat.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string body);
    }
}