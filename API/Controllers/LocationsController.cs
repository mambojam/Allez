using Application.Locations.Commands;
using Application.Locations.Queries;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    public class LocationsController : BaseApiController
    {       
            [HttpGet]
            public async Task<ActionResult<List<Location>>> GetLocations()
            {
                return await Mediator.Send(new GetLocationList.Query());
            }
            
            [HttpGet("{id}")]
            public async Task<ActionResult<Location>> GetLocation(string id)
            {

                return await Mediator.Send(new GetLocationDetails.Query{Id = id});
            }
            
            [HttpPost]
            public async Task<ActionResult<string>> CreateLocation(Location location)
            {
                return await Mediator.Send(new CreateLocation.Command{Location = location});
            }

            [HttpPut]
            public async Task<ActionResult>  EditLocation(Location location)
            {
                await Mediator.Send(new EditLocation.Command{Location = location});

                return NoContent();
            }
            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(string id)
            {
                await Mediator.Send(new DeleteLocation.Command{Id = id});

                return NoContent();
            }
            
        }
    }

        
        