using Domain.Entities;
using MediatR;
using System;

namespace Application.Features.Queries
{
    public class GetHouseByIdQuery : IRequest<House>
    {
        public Guid Id { get; set; }
    }
}
