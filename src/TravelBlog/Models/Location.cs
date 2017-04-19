using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public intLocationId { get; set; }
        public string Name { get; set; }
    }
}
