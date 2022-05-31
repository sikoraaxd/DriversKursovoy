using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DriversKursovoy.Data
{
    internal class Car
    {
        [Key]
        [MaxLength(10)]
        public string Number { get; set; }
        [Required]
        [MaxLength(40)]
        public string Model { get; set; }
        [Required]
        [MaxLength(5)]
        public string PathNumber { get; set; }
        [Column(TypeName = "uuid[]")]
        public List<Guid> drivers { get; set; }

    }
}
