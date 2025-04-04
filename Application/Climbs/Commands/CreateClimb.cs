
using Domain;
using MediatR;
using Persistence;

namespace Application.Climbs.Commands
{
    public class CreateClimb
    {
        public class Command : IRequest<string> 
        {
            public required Climb Climb { get; set; }          
        }

        public class Handler(DataContext context) : IRequestHandler<Command, string>
        {
            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                context.Climbs.Add(request.Climb);

                await context.SaveChangesAsync(cancellationToken);

                return request.Climb.Id;
            }
        }
    }
}