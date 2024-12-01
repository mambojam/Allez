using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public enum Style {
        Bouldering, Sport, Mixed
    }

    public enum VenueType {
        Indoor, Outdoor
    }

    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RockType { get; set; }
        public Style Style { get; set; }
        public VenueType VenueType {get; set;}
        public string Description { get; set; }
        public string Approach {get; set;}
        public string Conditions {get; set;}
        public string Address {get; set;}


        public ICollection<Block> Blocks { get; set; }
        public ICollection<Route> Routes { get; set; }
    }
}