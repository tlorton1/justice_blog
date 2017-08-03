namespace JusticeWebApp.Services
{
    public interface IMessageService
    {
        bool SendMessage(string name, string email, string message);
    }
}