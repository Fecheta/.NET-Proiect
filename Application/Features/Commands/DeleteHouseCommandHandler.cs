using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class DeleteHouseCommandHandler : IRequestHandler<DeleteHouseCommand, int>
    {
        private readonly IHouseRepository repository;

        public DeleteHouseCommandHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public Task<int> Handle(DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            House house = repository.GetByIdAsync(request.Id).Result;
            if (house == null)
            {
                throw new ArgumentNullException("request", "No house with this id was found");
            }

            return HandleInternal(house, request, cancellationToken);

        }

        public async Task<int> HandleInternal(House house, DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            await repository.DeleteAsync(house);

            return house.Id;
        }
    }
}
