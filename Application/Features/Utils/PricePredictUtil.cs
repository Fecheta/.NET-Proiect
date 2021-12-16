using MediatR;

namespace Application.Features.Utils
{
    public class PricePredictUtil : IRequest<float>
    {
        public string Zipcode { get; set; }
        public float Bedrooms { get; set; }
        public float Bathrooms { get; set; }
        public float SquareFeet { get; set; }
        public float YearBuit { get; set; }
        public string Floors { get; set; }

        
    }
}
