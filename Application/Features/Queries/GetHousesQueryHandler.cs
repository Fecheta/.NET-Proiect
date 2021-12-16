using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace Application.Features.Queries
{
    public class GetHousesQueryHandler : IRequestHandler<GetHousesQuery, List<House>>
    {
        private readonly IHouseRepository repository;

        public GetHousesQueryHandler(IHouseRepository repository)
        {
            this.repository = repository;
        }
        public async Task<List<House>> Handle(GetHousesQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<House> housesEnum =  await repository.GetAllAsync();
            return housesEnum.ToList();
            
        }
    }
}
