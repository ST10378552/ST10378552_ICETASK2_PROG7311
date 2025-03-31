namespace OrderProcessingSystem.Models
{
    public class OrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Simulate order processing
            Console.WriteLine($"Order {order.OrderId} processed with total amount {order.TotalAmount}");
        }
    }
}
