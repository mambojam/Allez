using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Locations.Queries
{
    public class GetLocationDetails
    {
        public class Query : IRequest<Location>
        {
            public required string Id { get; set; }
        }
        public class Handler(DataContext context) : IRequestHandler<Query, Location>
        {
            public async Task<Location> Handle(Query request, CancellationToken cancellationToken)
            {
                var location = await context.Locations.FindAsync([request.Id], cancellationToken);

                if (location == null) throw new Exception("activity not found");

                return location;

            }
        }
    }
}