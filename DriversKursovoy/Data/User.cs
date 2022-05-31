using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DriversKursovoy.Data
{
    internal class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(40)]
        public string Login { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Column(TypeName="jsonb")]
        public string DaysOfWork { get; set; }

        [Required]
        public string Role { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }

    internal class Schedule
    {
        public List<string> Monday { get; set; }
        public List<string> Tuesday { get; set; }
        public List<string> Wednesday { get; set; }
        public List<string> Thursday { get; set; }
        public List<string> Friday { get; set; }
        public List<string> Saturday { get; set; }
        public List<string> Sunday { get; set; }

        public Schedule()
        {
            Monday = new List<string>();
            Tuesday = new List<string>();   
            Wednesday = new List<string>();
            Thursday = new List<string>();
            Friday = new List<string>();
            Saturday = new List<string>();
            Sunday = new List<string>();
        }
    }
}


