using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Features.Queries
{
    public class GetHousesQuery : IRequest<IEnumerable<House>>
    {
    }
}
