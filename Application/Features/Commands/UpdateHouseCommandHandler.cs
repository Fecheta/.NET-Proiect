using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class UpdateHouseCommandHandler : IRequestHandler<UpdateHouseCommand, int>
    {
        private readonly IHouseRepository repository;

        public UpdateHouseCommandHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public Task<int> Handle(UpdateHouseCommand request, CancellationToken cancellationToken)
        {
            House house = repository.GetByIdAsync(request.Id).Result;
            if (house == null || house.Id is 0)
            {
                throw new ArgumentNullException(nameof(request), "No house with this id was found");
            }

            return HandleInternal(house, request, cancellationToken);
        }

        public async Task<int> HandleInternal(House house, UpdateHouseCommand request, CancellationToken cancellationToken)
        {
            house.Bedrooms = request.Bedrooms;
            house.Bathrooms = request.Bathrooms;
            house.SquareFeet = request.SquareFeet;
            house.Floors = request.Floors;
            house.ZipCode = request.ZipCode;
            house.YearBuilt = request.YearBuilt;
            house.Price = request.Price;

            await repository.UpdateAsync(house);

            return house.Id;
        }
    }
}
