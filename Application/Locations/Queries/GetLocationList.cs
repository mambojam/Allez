using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Locations.Queries
{
    public class GetLocationList
    {
        public class Query : IRequest<List<Location>> {}

        public class Handler(DataContext context) : IRequestHandler<Query, List<Location>>
        {
            public async Task<List<Location>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await context.Locations.ToListAsync(cancellationToken);
            }
        }
    }
}