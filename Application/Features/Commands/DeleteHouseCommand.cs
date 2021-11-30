using MediatR;
using System;

namespace Application.Features.Commands
{
    public class DeleteHouseCommand : IRequest<Guid>
    {
        public Guid Id {  get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
