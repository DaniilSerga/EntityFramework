using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.DatabaseModels
{
    internal class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Employee Employee { get; set; }
    }
}
