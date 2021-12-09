using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Queries
{
    public class GetHouseByIdQueryHandler : IRequestHandler<GetHouseByIdQuery, House>
    {
        private readonly IHouseRepository repository;

        public GetHouseByIdQueryHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<House> Handle(GetHouseByIdQuery request, CancellationToken cancellationToken)
        {
            var house = await repository.GetByIdAsync(request.Id);
            if (house == null)
            {
                throw new ArgumentNullException("request", "No house with this id was found");
            }

            return house;
        }
    }
}
