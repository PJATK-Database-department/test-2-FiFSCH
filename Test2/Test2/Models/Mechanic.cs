using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class Mechanic
    {
        [Key]
        [Required]
        public int IdMechanic { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        public ICollection<Inspection> Inspections { get; set; }
    }
}
