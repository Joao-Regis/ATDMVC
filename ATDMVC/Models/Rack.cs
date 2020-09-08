using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ATDMVC.Models
{
    public class Rack
    {
        [Key]
        public int RackID { get; set; }

        public int Invoice { get; set; }

        public DateTime InstallDate { get; set; }

        public int RacksInstalled { get; set; }

        [ForeignKey("RackType")]
        public int RackTypeID { get; set; }

        public String RackColor { get; set; }

        public DateTime LastInspectionDate { get; set; }

        public String Condition { get; set; }          

        public String Latitude { get; set; }

        public String Longitude { get; set; }

        [ForeignKey("Location")]
        public int LocationID { get; set; }

        public String Notes { get; set; }

    }
}
