using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATDMVC.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        public String LocationName { get; set; }

        public String Intersection { get; set; }

        public String Address { get; set; }

        public String City { get; set; }

        public int Zip { get; set; }

        public int CouncilDistrict { get; set; }

    }
}
