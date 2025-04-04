using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Climbs.Commands
{
    public class DeleteClimb
    {
        public class Command : IRequest
        {
            public string Id { get; set; }
        }

        public class Handler(DataContext context) : IRequestHandler<Command>
        {
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var climb = await context.Climbs
                    .FindAsync([request.Id], cancellationToken)
                    ?? throw new Exception("Cannot find climb");
                
                context.Climbs.Remove(climb);

                await context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}