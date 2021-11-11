using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ComputerShop.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Category Name Not Empty")]
        [StringLength(20,ErrorMessage ="Please maximum 20 charackters")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool Status {get;set;}
        public List<Computer> Computers { get; set; }
    }
}
