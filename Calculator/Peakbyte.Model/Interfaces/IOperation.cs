using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peakbyte.Model
{
    public interface IOperation
    {
        bool IsMatch(ComputeUnit computeUnit);
        Calculation Operate(ComputeUnit computeUnit);
    }
}
