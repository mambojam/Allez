using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public class Block
    {
        public enum Hueco {
            VB, V0, V1, V2, V3, V4, V5, V6, V7, V8, V9, V10, V11, V12, V13, V14, V15, V16
        }
        public Guid Id {get; set;}
        public string Name {get; set;}
        [Required]
        public Hueco Grade { get; set;}
        public string Description { get; set; } = "";
        public decimal? Rating { get; set; }
        public Guid LocationId { get; set; }
        public Location Location { get; set; }

    }
}