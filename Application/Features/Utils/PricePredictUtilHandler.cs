using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Utils
{
    public class PricePredictUtilHandler : IRequestHandler<PricePredictUtil, decimal>
    {
        private readonly IHouseRepository repository;

        public PricePredictUtilHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<decimal> Handle(PricePredictUtil request, CancellationToken cancellationToken)
        {
            var entity = await repository.GetByZipcodeAndBedrooms(request.Zipcode, request.Bedrooms);
            
            if(entity is null)
            {
                return -1;
            }
            return decimal.Parse(entity.Price);
        }
    }
}
