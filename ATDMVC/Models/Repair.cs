using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ATDMVC.Models
{
    public class Repair
    {
        [Key]
        public int RepairID { get; set; }

        public String RepairType { get; set; }

        public String Comments { get; set; }

        public String Condition { get; set; }

        public String Status { get; set; }

        public DateTime RepairDate { get; set; }

        public DateTime InspectionDate { get; set; }

        public int NumberRemoved { get; set; }

        public int NumberInstalled { get; set; }

        [ForeignKey("Rack")]
        public int RackID { get; set; }

    }
}
