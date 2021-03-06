using Application.Features.Commands;
using Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class HousesController : BaseController
    {
        public HousesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateHouseCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await mediator.Send(new GetHousesQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            GetHouseByIdQuery query = new GetHouseByIdQuery();
            query.Id = id;
            return Ok(await mediator.Send(query));
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateHouseCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            return Ok(await mediator.Send(command));
        }
    }
}
