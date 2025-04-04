using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Locations.Commands
{
    public class DeleteLocation
    {
        public class Command : IRequest
        {
            public string Id { get; set; }
        }

        public class Handler(DataContext context) : IRequestHandler<Command>
        {
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var location = await context.Locations
                    .FindAsync([request.Id], cancellationToken)
                    ?? throw new Exception("Cannot find Location");
                
                context.Locations.Remove(location);

                await context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}