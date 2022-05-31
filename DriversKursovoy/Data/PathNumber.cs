using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriversKursovoy.Data
{
    internal class PathNumber
    {
        [Key]
        [MaxLength(10)]
        public string Number { get; set; }
        [Required]
        [Column(TypeName = "jsonb")]
        public string PathSequence { get; set; }
    }
}
