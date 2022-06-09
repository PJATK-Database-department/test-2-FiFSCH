using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Inspection
    {
        [Key]
        [Required]
        public int IdInspection { get; set; }
        [Required]
        public int IdCar { get; set; }
        [Required]
        public int IdMechanic { get; set; }
        [Required]
        public DateTime InspectionDate { get; set; }
        [Required]
        [MaxLength(300)]
        public string Comment { get; set; }
        [ForeignKey("IdCar")]
        public Car Car { get; set; }
        [ForeignKey("IdMechanic")]
        public Mechanic Mechanic { get; set; }
        public ICollection<ServiceTypeDictInspection> ServiceTypeDictInspections { get; set; }
    }
}
