using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peakbyte.Model
{
    [NotMapped]
    public class BasicComputation : IComputation
    {
        List<IOperation> operations;

        public BasicComputation()
        {
            operations = new List<IOperation>();
            operations.Add(new AddOperation());
            operations.Add(new SubtractOperation());
        }

        public Calculation Compute(ComputeUnit computeUnit)
        {
            return operations.First(o => o.IsMatch(computeUnit)).Operate(computeUnit);
        }
    }
}
