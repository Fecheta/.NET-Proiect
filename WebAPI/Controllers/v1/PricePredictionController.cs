using Application.Features.Commands;
using Application.Features.Utils;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers.v1
{
    public class PricePredictionController : BaseController
    {
        public PricePredictionController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Predict([FromBody] CreateHouseCommand command)
        {
            return Ok(await mediator.Send(new PricePredictUtil()));
        }

    }
}
