using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCoreApp.Models
{
    public class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int employeeId { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string firstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string lastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string gender { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string designation { get; set; }

        [Required]
        [Column(TypeName = "varchar(40)")]
        public string department { get; set; }

    }
}
