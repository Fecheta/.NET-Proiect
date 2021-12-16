using Application.Interfaces;
using MediatR;
using PricePrediction;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Utils
{
    public class PricePredictUtilHandler : IRequestHandler<PricePredictUtil, float>
    {
        private readonly IHouseRepository repository;
        private readonly Program program = new();

        public PricePredictUtilHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<float> Handle(PricePredictUtil request, CancellationToken cancellationToken)
        {
            /*var entity = await repository.GetByZipcodeAndBedrooms(request.Zipcode, request.Bedrooms);
            
            if(entity is null)
            {
                return -1;
            }
            return decimal.Parse(entity.Price);*/



             var price = await program.PricePredict(request);


            if (price == null) return -1;
            else return price;

            
        }
    }
}
