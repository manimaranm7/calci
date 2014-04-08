using Peakbyte.Data.Contracts;
using Peakbyte.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Peakbyte.API.Controllers
{
    public class CalculationController : ApiControllerBase
    {
        private IComputation Computation { get; set; }

        public CalculationController(IPeakbyteUoW uow, IComputation computation)
        {
            Uow = uow;
            Computation = computation;
        }

        public IEnumerable<Calculation> Get()
        {
            return Uow.Calculation.GetAll().OrderBy(c => c.Id);
        }

        // Create a new Calculation
        // POST /api/Calculation
        [ActionName("calculate")]
        [HttpPost]
        public HttpResponseMessage Calculate(int operand1, int operand2, int operationType)
        {
            ComputeUnit computeUnit = new ComputeUnit(operand1, operand2, (OPERATION_TYPE)operationType);            
            Calculation result = Computation.Compute(computeUnit);

            Uow.Calculation.Add(result);
            Uow.Commit();

            var response = Request.CreateResponse(HttpStatusCode.Created, result);

            // Compose location header that tells how to get this Calculation
            // e.g. ~/api/Calculation/5
            response.Headers.Location =
                new Uri(Url.Link(WebApiConfig.ControllerAndId, new { id = result.Id }));

            return response;
        }
    }
}
