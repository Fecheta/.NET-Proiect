using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class CreateHouseCommandHandler : IRequestHandler<CreateHouseCommand, int>
    {
        private readonly IHouseRepository repository;

        public CreateHouseCommandHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<int> Handle(CreateHouseCommand request, CancellationToken cancellationToken)
        {
            var house = new House
            {
                Bedrooms = request.Bedrooms,
                Bathrooms = request.Bathrooms,
                SquareFeet = request.SquareFeet,
                Floors = request.Floors,
                ZipCode = request.ZipCode,
                YearBuilt = request.YearBuilt,
                Price = request.Price
            };

            await repository.AddAsync(house);
            return house.Id;
        }
    }
}
