using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerShop.Data.Models
{
    public class Computer
    {
        public int ComputerID { get; set; }
        [Required(ErrorMessage = "Category Name Not Empty")]
        [StringLength(20,ErrorMessage ="Please maximum 20 charackters")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
