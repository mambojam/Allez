using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Route
    {
        public enum French {
            f3, f4, f5, f6a, f6aa, f6b, f6bb, f6c, f6cc, f7a, f7aa, f7b, f7bb, f7c, f7cc, f8a, f8aa, f8b, f8bb, f8c, f8cc, f9a, f9aa, f9b, f9bb, f9c, f9cc 
        }
        public Guid Id {get; set;}
        public string Name {get; set;}
        [Required]
        public French Grade { get; set;}
        public string Description { get; set; } = "";
        public decimal? Rating { get; set; }
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
    }
}