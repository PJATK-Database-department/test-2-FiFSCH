using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models
{
    public class ServiceTypeDictInspection
    {
        [Key]
        [Required]
        public int IdServiceType { get; set; }
        [Key]
        [Required]
        public int IdInspection  { get; set; }
       
        [MaxLength(300)]
        public string? Comments { get; set; }
        [ForeignKey("IdServiceType")]
        public ServiceTypeDict ServiceTypeDict { get; set; }
        [ForeignKey("IdInspection")]
        public Inspection Inspection { get; set; }

    }
}
