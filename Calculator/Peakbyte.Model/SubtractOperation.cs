using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peakbyte.Model
{
    [NotMapped]
    public class SubtractOperation : IOperation
    {
        public bool IsMatch(ComputeUnit computeUnit)
        {
            return computeUnit.operationType == OPERATION_TYPE.SUBTRACT;
        }

        public Calculation Operate(ComputeUnit computeUnit)
        {
            Calculation computeResult = new Calculation();
            computeResult.Result = (computeUnit.operand1 - computeUnit.operand2).ToString();
            return computeResult;
        }
    }
}
