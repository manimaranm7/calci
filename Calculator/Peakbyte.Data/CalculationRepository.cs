using Peakbyte.Data.Contracts;
using Peakbyte.Model;
using System.Data.Entity;
using System.Linq;

namespace Peakbyte.Data
{
    public class CalculationRepository : EFRepository<Calculation>, ICalculationRepository
    {
        public CalculationRepository(DbContext context) : base(context) { }

        public IQueryable<Calculation> GetCalculations()
        {
            return DbContext.Set<Calculation>().Where(Calculation => Calculation.Id < 100);
        }
    }
}
