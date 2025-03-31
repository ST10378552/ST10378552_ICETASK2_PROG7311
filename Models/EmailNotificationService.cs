namespace OrderProcessingSystem.Models
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
