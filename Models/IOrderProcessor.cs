namespace OrderProcessingSystem.Models
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Order order);
    }
}
