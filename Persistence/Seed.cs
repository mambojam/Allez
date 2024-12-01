using System.Threading.Tasks.Dataflow;
using Domain;
using Microsoft.VisualBasic;
using Persistence.Repositories;

namespace Persistence
{
    public class Seed
        {
    //     private readonly IBaseRepository<Location> _locationRepository;
    //     private readonly IBaseRepository<Block> _blockRepository;
    //     private readonly IBaseRepository<Route> _routeRepository;

    //     public Seed(
    //     IBaseRepository<Location> locationRepository,
    //     IBaseRepository<Block> blockRepository,
    //     IBaseRepository<Route> routeRepository)
    // {
    //     _locationRepository = locationRepository;
    //     _blockRepository = blockRepository;
    //     _routeRepository = routeRepository;
    // }
        public async Task SeedData(DataContext context)
        {
            if (context.Locations.Any()) return;


            Guid sirhowyId = Guid.NewGuid();
            Guid bouldersId = Guid.NewGuid();
            Guid flashpointId = Guid.NewGuid();

            var seedLocations = new List<Location>{
                new Location {
                    Id = bouldersId,
                    Name = "Boulders",
                    RockType = null,
                    Style = Style.Mixed,
                    VenueType = VenueType.Indoor,
                    Description = "Looking for a thrilling all-weather activity in Cardiff? Look no further than Boulders Newport Road. We're not just a climbing center; we're your gateway to adventure, suitable for all ages and abilities."
                                    + "Climbing for All Ages and Abilities: Whether you're an experienced climber or a first-timer, our expansive facility offers a wide range of climbing experiences. From bouldering challenges that will test your strength and problem-solving skills to roped climbing, lead climbing, and the excitement of autobelays, there's something here for everyone. Experiences with our instructors start from age 6+, but there are options for everyone from the age of 2."
                                    + "Escape Unpredictable Weather: Statistically speaking, Cardiff is the wettest city in the UK, but don't let the weather dictate your plans! Rain or shine, we provide a sheltered haven for anyone looking for an adventure. So, when you're searching for indoor activities in Cardiff, make us your top choice."
                                    + "Family-Friendly Adventure: Boulders Newport Road is perfect for family outings. Bring your loved ones for a day filled with fun, fitness, and quality time together. Our friendly staff ensures that everyone, from kids to adults, has a safe and enjoyable climbing experience."
                                    + "Discover the excitement of climbing in Cardiff at Boulders Newport Road. Join us for a memorable climbing experience that promises adventure and camaraderie. Book your session now, and let the climbing journey begin!",
                    Approach = null,
                    Conditions = null,
                    Address = "St Catherines Park, Cardiff CF24 2RZ",
                    Blocks = [],
                    Routes = []
                },
                new Location {
                    Id = sirhowyId,
                    Name = "Sirhowy",
                    RockType = "Sandstone",
                    Style = Style.Sport,
                    VenueType = VenueType.Outdoor,
                    Description = "Sirhowy is one of the best chunks of quarried sandstone in the area, made even better by its tranquil setting with little in the way of road traffic noise or onlookers. It also has its own picnic area complete with bench and tables! The best climbing is on The Rust Curtain with its brilliant line-up of fingery wall climbs, whilst the more recently developed Western Wall has plenty of excellent (slightly) easier climbing on some of the best rock around.",
                    Approach = "From the carpark follow the track towards the farm, as the road bends left and the farmhouse is on the right you'll reach a left turning through a green horse gate. Turn here and continue along the path over the bridge for 150m and you will reach the Sirhowy river briddleway. The crag is just across the bridleway in the trees.",
                    Conditions = "Suffers from seepage. Best on a warm summers day when the trees provide welcome shade. the upper tier can also be a great spot for catching th last of the sun when the nights start drawing in.",
                    Address = "2 Railway Cottages, Wattsville, Crosskeys, Newport NP11 7PU",
                    Blocks = [],
                    Routes = []
                },

                new Location {
                    Id = flashpointId,
                    Name = "Flashpoint Cardiff",
                    RockType = null,
                    Style = Style.Bouldering,
                    VenueType = VenueType.Indoor,
                    Description = "Find us in Freemans Parc in the centre of Cardiff! Climbing centre designed with climbers of all abilities in mind; from new climbers to those looking for incredible training facilities. For those new to climbing and bouldering in Cardiff, we have an amazing community where you can get friendly advice and get to know new friends, or book onto an instructed course. Our routes are changed weekly which means there is always something fresh to try, even for the most dedicated of climbers.",
                    Approach = null,
                    Conditions = null,
                    Address = "Freemans Parc, 236 Penarth Rd, Cardiff CF11 8EQ",
                    Blocks = [],
                    Routes = []
                }
        };

            var sirhowyRoutes = new List<Route>
        {
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "Gott in Himmel",
            Grade = Route.French.f7a,
            Description = "A classic and challenging route with interesting holds.",
            Rating = null,
            LocationId = sirhowyId // Replace with the actual seeded location GUID
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "Butcher Heinrich",
            Grade = Route.French.f7b,
            Description = "Sharp and technical climb with delicate moves.",
            Rating = null,
            LocationId = sirhowyId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "Strange Little Girl",
            Grade = Route.French.f6c,
            Description = "Quirky route with a mix of balance and power.",
            Rating = null,
            LocationId = sirhowyId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "'King Ada",
            Grade = Route.French.f7b,
            Description = "Steep overhang with sustained difficulty throughout.",
            Rating = null,
            LocationId = sirhowyId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "Skanderbeg",
            Grade = Route.French.f7b,
            Description = "Powerful moves with a rewarding finish.",
            Rating = null,
            LocationId = sirhowyId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "Skanderbeg (Direct)",
            Grade = Route.French.f7bb,
            Description = "Direct variation with extra difficulty on the crux.",
            Rating = null,
            LocationId = sirhowyId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "King Zog",
            Grade = Route.French.f7aa,
            Description = "Technical and demanding with intricate sequences.",
            Rating = null,
            LocationId = sirhowyId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "Face",
            Grade = Route.French.f7bb,
            Description = "A face climb with delicate and intricate moves.",
            Rating = null,
            LocationId = sirhowyId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = "Mawr, Mawr, Mawr",
            Grade = Route.French.f7a,
            Description = "A lengthy endurance testpiece with flowing moves.",
            Rating = null,
            LocationId = sirhowyId
            }
        };
        var bouldersRoutes = new List<Route> {
            new Route
            {
            Id = Guid.NewGuid(),
            Name = null,
            Grade = Route.French.f7a,
            Description = "",
            Rating = null,
            LocationId = bouldersId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = null,
            Grade = Route.French.f6a,
            Description = "",
            Rating = null,
            LocationId = bouldersId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = null,
            Grade = Route.French.f5,
            Description = "",
            Rating = null,
            LocationId = bouldersId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = null,
            Grade = Route.French.f7b,
            Description = "",
            Rating = null,
            LocationId = bouldersId
            },
            new Route
            {
            Id = Guid.NewGuid(),
            Name = null,
            Grade = Route.French.f6c,
            Description = "",
            Rating = null,
            LocationId = bouldersId
            }
        };
        var bouldersBoulders = new List<Block> {
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.VB,
                Description = "",
                Rating = null,
                LocationId = bouldersId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V0,
                Description = "",
                Rating = null,
                LocationId = bouldersId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V1,
                Description = "",
                Rating = null,
                LocationId = bouldersId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V3,
                Description = "",
                Rating = null,
                LocationId = bouldersId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V5,
                Description = "",
                Rating = null,
                LocationId = bouldersId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V5,
                Description = "",
                Rating = null,
                LocationId = bouldersId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V6,
                Description = "",
                Rating = null,
                LocationId = bouldersId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V7,
                Description = "",
                Rating = null,
                LocationId = bouldersId
            }
        };

        var flashBlocks = new List<Block> {
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V7,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V7,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V6,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V6,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V5,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V5,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V4,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V4,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
            new Block {
                Id = Guid.NewGuid(),
                Name = null,
                Grade = Block.Hueco.V3,
                Description = "",
                Rating = null,
                LocationId = flashpointId
            },
        };
        
            await context.Locations.AddRangeAsync(seedLocations);
            await context.SaveChangesAsync();
            Console.WriteLine($"Locations Table finished inserting, location Ids are: \nboulders: {bouldersId}"
            + $"\nsirhowy: {sirhowyId} \nflashpoint: {flashpointId}");

            await context.Routes.AddRangeAsync(sirhowyRoutes);
            await context.Routes.AddRangeAsync(bouldersRoutes);
            await context.Blocks.AddRangeAsync(bouldersBoulders);
            await context.Blocks.AddRangeAsync(flashBlocks);
            await context.SaveChangesAsync();
        }
    }
}