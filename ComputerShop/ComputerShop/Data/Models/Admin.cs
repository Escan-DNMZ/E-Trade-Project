using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerShop.Data.Models
{
    public class Admin
    {
           [Key] //Otomatik id getirir
        public int AdminID { get; set; }
        [StringLength(20)] //maksimum harf değerini belirler
        public string UserName { get; set; }
        [StringLength(20)]//maksimum harf değerini belirler
        public string Password { get; set; }
        [StringLength(1)]//maksimum harf değerini belirler
        public string AdminRole { get; set; }
    }
}