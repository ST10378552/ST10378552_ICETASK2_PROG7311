namespace OrderProcessingSystem.Models
{
    public class OrderValidator : IOrderValidator
    {
        public bool ValidateOrder(Order order)
        {
            // Validate the order (e.g., check if products are available)
            return order.Products.Any();
        }
    }
}
