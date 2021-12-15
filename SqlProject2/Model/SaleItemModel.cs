using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject2.Model
{
    public class SaleItemModel
    {
        [Key]
        public string ProductSaleName { get; set; }
        
        [Required]
        public string Price { get; set; }

        public DateTime? Startdate { get; set; }

        public DateTime? Enddate { get; set; }
    }
}
