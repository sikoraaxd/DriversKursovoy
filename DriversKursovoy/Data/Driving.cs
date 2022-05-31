using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriversKursovoy.Data
{
    internal class Driving
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public User Driver { get; set; }
        [Required]
        public Car Car { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
