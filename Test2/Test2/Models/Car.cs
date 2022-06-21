using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Car
    {
        [Key]
        [Required]
        public int IdCar { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int ProductionYear { get; set; }
        public ICollection<Inspection> Inspections { get; set; }
    }
}
