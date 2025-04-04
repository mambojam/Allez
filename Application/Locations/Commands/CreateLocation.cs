using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Locations.Commands
{
    public class CreateLocation
    {
        public class Command : IRequest<string> 
        {
            public required Location Location { get; set; }          
        }

        public class Handler(DataContext context) : IRequestHandler<Command, string>
        {
            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                context.Locations.Add(request.Location);

                await context.SaveChangesAsync(cancellationToken);

                return request.Location.Id;
            }
        }
    }
}