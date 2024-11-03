using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class OrderManager : IOrderService
    {
        private readonly IRepositoryManager _manager;

        public OrderManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IQueryable<Order> Orders => _manager.Order.Orders;

        public int NumberOfInProcess => _manager.Order.NumberOfInProcess;

        public void Complete(int id)
        {
            _manager.Order.Complete(id);
            _manager.Save();
        }

        public Order? GetOneOrder(int id)
        {
            var order=_manager.Order.GetOneOrder(id);
            if(order is null)
                throw new Exception("Order is null.");
            return order;
        }

        public void SaveOrder(Order order)
        {
            _manager.Order.SaveOrder(order);
        }
    }
}