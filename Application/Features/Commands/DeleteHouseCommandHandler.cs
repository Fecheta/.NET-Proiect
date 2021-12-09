using Application.Interfaces;
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
        public async Task<int> Handle(DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            var house = repository.GetByIdAsync(request.Id).Result;
            if (house == null)
            {
                throw new ArgumentNullException("House doesn't exist");
            }

            await repository.DeleteAsync(house);

            return house.Id;

        }
    }
}
