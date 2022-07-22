using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.DatabaseModels
{
    [Table("Employee")]
    internal class Employee : Person
    {
        public string MobilePhone { get; set; }

        public int PositionId { get; set; }

        public decimal Salary { get; set; }

        public Position Position { get; set; }
    }
}
