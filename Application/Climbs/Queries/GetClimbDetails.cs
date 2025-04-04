using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Climbs.Queries
{
    public class GetClimbDetails
    {
        public class Query : IRequest<Climb>
        {
            public required string Id { get; set; }
        }
        public class Handler(DataContext context) : IRequestHandler<Query, Climb>
        {
            public async Task<Climb> Handle(Query request, CancellationToken cancellationToken)
            {
                var climb = 
                    await context.Climbs.FindAsync([request.Id], cancellationToken) 
                    ?? throw new Exception("activity not found");
                return climb;

            }
        }
    }
}