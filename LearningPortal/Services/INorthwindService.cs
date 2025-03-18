using LearningPortal.Models.Northwind;

namespace LearningPortal.Northwind
{
    public interface INorthwindService
    {
        Task<List<OrdersType>> GetOrders();
    }
}
