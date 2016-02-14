namespace Core.Interfaces
{
    public interface SendMail
    {
        void sendMail(string recipient, string subject, string message);
    }
}
