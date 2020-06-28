using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4
{
    public class DataChange
    {
        [Display(Name = "Дата начала")]
       public string Sinse { get; set; }
        [Display(Name = "Дата конца")]
        public string For { get; set; }
        [Display(Name = "ID параметра")]
        public int Id { get; set; }
    }
}
