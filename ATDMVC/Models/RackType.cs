using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATDMVC.Models
{
    public class RackType
    {
        [Key]
        public int RackTypeID { get; set; }

        public String Description { get; set; }

        public int Qty { get; set; }

    }
}
