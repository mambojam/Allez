using Application.Climbs.Commands;
using Application.Climbs.Queries;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    public class ClimbsController : BaseApiController
    {
            [HttpGet]
            public async Task<ActionResult<List<Climb>>> GetClimbs()
            {
                return await Mediator.Send(new GetClimbList.Query());
            }
            
            [HttpGet("{id}")]
            public async Task<ActionResult<Climb>> GetClimb(string id)
            {

                return await Mediator.Send(new GetClimbDetails.Query{Id = id});
            }
            
            [HttpPost]
            public async Task<ActionResult<string>> CreateClimb(Climb climb)
            {
                return await Mediator.Send(new CreateClimb.Command{Climb = climb});
            }

            [HttpPut]
            public async Task<ActionResult>  EditClimb(Climb climb)
            {
                await Mediator.Send(new EditClimb.Command{Climb = climb});

                return NoContent();
            }
            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(string id)
            {
                await Mediator.Send(new DeleteClimb.Command{Id = id});

                return NoContent();
            }
    }
            
}

    