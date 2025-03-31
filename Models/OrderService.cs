namespace OrderProcessingSystem.Models
{
     public class OrderService
    {
        private readonly IOrderProcessor _orderProcessor;
        private readonly INotificationService _notificationService;
        private readonly IOrderValidator _orderValidator;

        public OrderService(
            IOrderProcessor orderProcessor,
            INotificationService notificationService,
            IOrderValidator orderValidator)
        {
            _orderProcessor = orderProcessor;
            _notificationService = notificationService;
            _orderValidator = orderValidator;
        }

        public void PlaceOrder(Order order)
        {
            if (_orderValidator.ValidateOrder(order))
            {
                _orderProcessor.ProcessOrder(order);
                _notificationService.SendNotification($"Order {order.OrderId} placed successfully!");
            }
            else
            {
                _notificationService.SendNotification("Order validation failed.");
            }
        }
    }
}
