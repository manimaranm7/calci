using Peakbyte.Model;
namespace Peakbyte.Data.Contracts
{
    public interface IPeakbyteUoW
    {
        // Save pending changes to the data store.
        void Commit();

        // Repositories
        ICalculationRepository Calculation { get; }
    }
}
