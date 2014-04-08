using Peakbyte.Model;
using System.Linq;

namespace Peakbyte.Data.Contracts
{
    public interface ICalculationRepository : IRepository<Calculation>
    {
        IQueryable<Calculation> GetCalculations();
    }
}
