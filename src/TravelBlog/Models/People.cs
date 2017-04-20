﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    [Table("Peoples")]
    public class People
    {
        public People()
        {
            this.Locations = new HashSet<Location>();
        }

        [Key]
        public int PeopleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
