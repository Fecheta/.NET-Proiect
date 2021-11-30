using MediatR;
using System;

namespace Application.Features.Commands
{
    public class DeleteHouseCommand : IRequest<Guid>
    {
        public Guid Id {  get; set; }

        public int Bedrooms { get; set; }

        public int Bathrooms { get; set; }

        public decimal SquareFeet { get; set; }

        public int Floors { get; set; }

        public string ZipCode { get; set; }

        public DateTime YearBuilt { get; set; }

        public decimal Price { get; set; }
    }
}
