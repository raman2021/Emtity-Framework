using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject2.Model
{
    public class ProductModel
    {
        [Required]
        public string price { get; set; }
        public string ProductDescription { get; set; }

        [Key]
        public string ProductName { get; set; }
    }
}
