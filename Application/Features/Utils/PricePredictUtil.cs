using MediatR;

namespace Application.Features.Utils
{
    public class PricePredictUtil : IRequest<decimal>
    {
        public string Zipcode { get; set; }
        public string Bedrooms { get; set; }
    }
}
