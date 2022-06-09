using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class ServiceTypeDict
    {
        [Key]
        [Required]
        public int IdServiceType { get; set; }
        [Required]
        [MaxLength(20)]
        public string ServiceType { get; set; }
        [Required]
        public float Price { get; set; }
        public ICollection<ServiceTypeDictInspection> ServiceTypeDictInspections { get; set; }
    }
}
