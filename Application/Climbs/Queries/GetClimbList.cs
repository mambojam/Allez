using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Climbs.Queries
{
    public class GetClimbList
    {
        public class Query : IRequest<List<Climb>> 
        {

        }

        public class Handler(DataContext context) : IRequestHandler<Query, List<Climb>>
        {
            public async Task<List<Climb>> Handle(Query request, CancellationToken cancellationToken)
            {
                
                return await context.Climbs.ToListAsync(cancellationToken);
            }
        }
    }
}