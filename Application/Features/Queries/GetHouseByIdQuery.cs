using Domain.Entities;
using MediatR;
using System;

namespace Application.Features.Queries
{
    public class GetHouseByIdQuery : IRequest<House>
    {
        public int Id { get; set; }
    }
}
