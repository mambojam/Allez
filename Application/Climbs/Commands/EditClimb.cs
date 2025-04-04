using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Climbs.Commands
{
    public class EditClimb
    {
        public class Command : IRequest
        {
            public Climb Climb { get; set; } // Request content here
        }

        public class Handler(DataContext context, IMapper mapper) : IRequestHandler<Command>
        {
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var climb = await context.Climbs
                    .FindAsync([request.Climb.Id], cancellationToken) 
                    ?? throw new Exception("Cannot find climb");

                mapper.Map(request.Climb, climb);
                
                await context.SaveChangesAsync(cancellationToken);

            }
        }
    }
}