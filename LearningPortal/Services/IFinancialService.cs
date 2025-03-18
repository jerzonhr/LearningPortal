using LearningPortal.Models.Financial;

namespace LearningPortal.Financial
{
    public interface IFinancialService
    {
        Task<List<SalesType>> GetSales();
    }
}
