using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peakbyte.Model
{
    [NotMapped]
    public class ComputeUnit
    {
        public int operand1;
        public int operand2;
        public OPERATION_TYPE operationType;

        public ComputeUnit(int operand1, int operand2, OPERATION_TYPE operationType)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.operationType = operationType;
        }
    }
}
