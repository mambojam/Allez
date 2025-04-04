using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Locations.Commands
{
    public class EditLocation
    {
        public class Command : IRequest
        {
            public Location Location { get; set; } // Request content here
        }

        public class Handler(DataContext context, IMapper mapper) : IRequestHandler<Command>
        {
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var location = await context.Locations
                    .FindAsync([request.Location.Id], cancellationToken) 
                    ?? throw new Exception("Cannot find location");

                mapper.Map(request.Location, location);
                
                await context.SaveChangesAsync(cancellationToken);

            }
        }
    }
}