namespace OrderProcessingSystem.Models
{
    public interface IOrderValidator
    {
        bool ValidateOrder(Order order);
    }
}
