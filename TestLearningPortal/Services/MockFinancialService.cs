using LearningPortal.Models.Financial;

namespace LearningPortal.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<SalesType>> GetSales()
        {
            return Task.FromResult<List<SalesType>>(new());
        }
    }
}
