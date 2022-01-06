using Application.Interfaces;
using MediatR;
using PricePrediction;
using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.ML;

namespace Application.Features.Utils
{
    public class PricePredictUtilHandler : IRequestHandler<PricePredictUtil, float>
    {
        private readonly Program program = new();

        public async Task<float> Handle(PricePredictUtil request, CancellationToken cancellationToken)
        {
            var price = await program.PricePredict(request);


            if (price <= 1) return -1;
            else return price;

        }
    }
}
