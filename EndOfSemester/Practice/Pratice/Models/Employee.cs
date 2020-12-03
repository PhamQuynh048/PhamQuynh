using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pratice.Models
{
    public class Employee
    {
        public long Id { get; set; }

        public string FristName { get; set; }

        public string LastName { get; set; }

        public string gender { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Salary { get; set; }
    }
}
