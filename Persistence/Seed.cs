using Domain;

namespace Persistence
{
    public class Seed
        {
    //     private readonly IBaseRepository<Location> _locationRepository;
    //     private readonly IBaseRepository<Boulder> _BoulderRepository;
    //     private readonly IBaseRepository<Climb> _ClimbRepository;

    //     public Seed(
    //     IBaseRepository<Location> locationRepository,
    //     IBaseRepository<Boulder> BoulderRepository,
    //     IBaseRepository<Climb> ClimbRepository)
    // {
    //     _locationRepository = locationRepository;
    //     _BoulderRepository = BoulderRepository;
    //     _ClimbRepository = ClimbRepository;
    // }
        public async Task SeedData(DataContext context)
        {
            if (context.Locations.Any()) return;

            var sirhowyId = Guid.NewGuid().ToString();
            var bouldersId = Guid.NewGuid().ToString();
            var flashpointId = Guid.NewGuid().ToString();

            var seedLocations = new List<Location>();

            var Boulders = new Location {
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
                   
                };
                var Sirhowy = new Location 
                {
                    Id = sirhowyId,
                    Name = "Sirhowy",
                    RockType = "Sandstone",
                    Style = Style.Sport,
                    VenueType = VenueType.Outdoor,
                    Description = "Sirhowy is one of the best chunks of quarried sandstone in the area, made even better by its tranquil setting with little in the way of road traffic noise or onlookers. It also has its own picnic area complete with bench and tables! The best climbing is on The Rust Curtain with its brilliant line-up of fingery wall climbs, whilst the more recently developed Western Wall has plenty of excellent (slightly) easier climbing on some of the best rock around.",
                    Approach = "From the carpark follow the track towards the farm, as the road bends left and the farmhouse is on the right you'll reach a left turning through a green horse gate. Turn here and continue along the path over the bridge for 150m and you will reach the Sirhowy river briddleway. The crag is just across the bridleway in the trees.",
                    Conditions = "Suffers from seepage. Best on a warm summers day when the trees provide welcome shade. the upper tier can also be a great spot for catching th last of the sun when the nights start drawing in.",
                    Address = "2 Railway Cottages, Wattsville, Crosskeys, Newport NP11 7PU",
                   
                };

                var Flashpoint = new Location {
                    Id = flashpointId,
                    Name = "Flashpoint Cardiff",
                    RockType = null,
                    Style = Style.Bouldering,
                    VenueType = VenueType.Indoor,
                    Description = "Find us in Freemans Parc in the centre of Cardiff! Climbing centre designed with climbers of all abilities in mind; from new climbers to those looking for incredible training facilities. For those new to climbing and bouldering in Cardiff, we have an amazing community where you can get friendly advice and get to know new friends, or book onto an instructed course. Our Climbs are changed weekly which means there is always something fresh to try, even for the most dedicated of climbers.",
                    Approach = null,
                    Conditions = null,
                    Address = "Freemans Parc, 236 Penarth Rd, Cardiff CF11 8EQ",
                   
                };
        

            var sirhowyClimbs = new List<Climb>
        {
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "Gott in Himmel",
            Grade = "7a",
            DisciplineType = "Sport",
            Description = "A classic and challenging Climb with interesting holds.",
            Rating = 4.0m,
            Location = "Sirhowy"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "Butcher Heinrich",
            Grade = "7b",
            DisciplineType = "Sport",
            Description = "Sharp and technical climb with delicate moves.",
            Rating = 3.5m,
            Location = "Sirhowy"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "Strange Little Girl",
            Grade = "6c",
            DisciplineType = "Sport",
            Description = "Quirky Climb with a mix of balance and power.",
            Rating = 5.0m,
            Location = "Sirhowy"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "'King Ada",
            Grade = "7b",
            DisciplineType = "Sport",
            Description = "Steep overhang with sustained difficulty throughout.",
            Rating = 3.8m,
            Location = "Sirhowy"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "Skanderbeg",
            Grade = "7b",
            DisciplineType = "Sport",
            Description = "Powerful moves with a rewarding finish.",
            Rating = 3.5m,
            Location = "Sirhowy"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "Skanderbeg (Direct)",
            Grade = "7b+",
            DisciplineType = "Sport",
            Description = "Direct variation with extra difficulty on the crux.",
            Rating = 3.6m,
            Location = "Sirhowy"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "King Zog",
            Grade = "7a",
            DisciplineType = "Sport",
            Description = "Technical and demanding with intricate sequences.",
            Rating = 3.2m,
            Location = "Sirhowy"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "Face",
            Grade = "7b+",
            DisciplineType = "Sport",
            Description = "A face climb with delicate and intricate moves.",
            Rating = 3.7m,
            Location = "Sirhowy"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = "Mawr, Mawr, Mawr",
            Grade = "7a",
            DisciplineType = "Sport",
            Description = "A lengthy endurance testpiece with flowing moves.",
            Rating = 4.8m,
            Location = "Sirhowy"
            }
        };
        var bouldersClimbs = new List<Climb> {
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = null,
            Grade = "7a",
            DisciplineType = "Sport",
            Description = "",
            Rating = null,
            Location = "Boulders"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = null,
            Grade = "6a",
            DisciplineType = "Sport",
            Description = "",
            Rating = null,
            Location = "Boulders"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = null,
            Grade = "5a",
            DisciplineType = "Sport",
            Description = "",
            Rating = null,
            Location = "Boulders"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = null,
            Grade = "7b",
            DisciplineType = "Sport",
            Description = "",
            Rating = null,
            Location = "Boulders"
            },
            new Climb
            {
            Id = Guid.NewGuid().ToString(),
            Name = null,
            Grade = "6c",
            DisciplineType = "Sport",
            Description = "",
            Rating = null,
            Location = "Boulders"
            }
        };
        var bouldersBoulders = new List<Climb> {
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "VB",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
            Location = "Boulders"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V0",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
            Location = "Boulders"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V1",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
            Location = "Boulders"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V3",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
            Location = "Boulders"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V5",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
            Location = "Boulders"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V5",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
            Location = "Boulders"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V6",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
            Location = "Boulders"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V7",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
            Location = "Boulders"
            }
        };

        var flashBoulders = new List<Climb> {
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V7",
                DisciplineType = "Boulder",
                Description = "",
                Rating = 5.0m,
                Location = "Flashpoint"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V7",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
                Location = "Flashpoint"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V6",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
                Location = "Flashpoint"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V6",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
                Location = "Flashpoint"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V5",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
                Location = "Flashpoint"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V5",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
                Location = "Flashpoint"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V4",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
                Location = "Flashpoint"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V4",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
                Location = "Flashpoint"
            },
            new Climb {
                Id = Guid.NewGuid().ToString(),
                Name = null,
                Grade = "V3",
                DisciplineType = "Boulder",
                Description = "",
                Rating = null,
                Location = "Flashpoint"
            },
        };
        
            seedLocations.AddRange([Sirhowy, Boulders, Flashpoint]);
            await context.Locations.AddRangeAsync(seedLocations);
            

            await context.Climbs.AddRangeAsync(sirhowyClimbs);
            await context.Climbs.AddRangeAsync(bouldersClimbs);
            await context.Climbs.AddRangeAsync(bouldersBoulders);
            await context.Climbs.AddRangeAsync(flashBoulders);
            await context.SaveChangesAsync();
        }
    }
}