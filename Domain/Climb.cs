using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    
    public class Climb
    {

        // Would like to add logic to control the discipline and grade e.g. discipline must be sport/boulder/trad - grade if discipline == sport grade must be in list of sport grades
        public string Id {get; set;} = Guid.NewGuid().ToString();
        public string? Name {get; set;}
        public required string DisciplineType {get; set;}
        public required string Grade { get; set; }
        public string? Description { get; set; }
        public decimal? Rating { get; set; }
        public required string Location {get; set;}
    }
}