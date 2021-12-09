using FluentValidation;
using MediatR;
using System;

namespace Application.Features.Commands
{
    public class CreateHouseCommand : IRequest<int>
    {
        public string Bedrooms { get; set; }

        public string Bathrooms { get; set; }

        public string SquareFeet { get; set; }

        public string Floors { get; set; }

        public string ZipCode { get; set; }

        public string YearBuilt { get; set; }

        public string Price { get; set; }
    }

    public class CreateHouseCommandValidator : AbstractValidator<CreateHouseCommand>
    {
        public CreateHouseCommandValidator()
        {
            RuleFor(x => x.Bedrooms)
                .NotEmpty()
                .Matches(@"[1-9][0-9]*");

            RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThan("2000");
        }
    }
}
