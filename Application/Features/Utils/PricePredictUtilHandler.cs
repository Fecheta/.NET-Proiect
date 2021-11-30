using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Utils
{
    internal class PricePredictUtilHandler : IRequestHandler<PricePredictUtil, decimal>
    {
        public async Task<decimal> Handle(PricePredictUtil request, CancellationToken cancellationToken)
        {
            return 23241.230m;
        }
    }
}
