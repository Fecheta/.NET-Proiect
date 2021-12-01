﻿using Application.Interfaces;
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
        public async Task<int> Handle(UpdateHouseCommand request, CancellationToken cancellationToken)
        {
            var house = repository.GetByIdAsync(request.Id).Result;
            if (house == null || house.Id is 0)
            {
                throw new Exception("House doesn't exist!");
            }

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
