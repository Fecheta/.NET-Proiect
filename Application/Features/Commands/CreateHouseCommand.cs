using MediatR;
using System;

namespace Application.Features.Commands
{
    public class CreateHouseCommand : IRequest<Guid>
    {
        public string Bedrooms { get; set; }

        public string Bathrooms { get; set; }

        public string SquareFeet { get; set; }

        public string Floors { get; set; }

        public string ZipCode { get; set; }

        public string YearBuilt { get; set; }

        public string Price { get; set; }
    }
}
