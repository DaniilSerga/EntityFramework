using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.DatabaseModels
{
    [Table("Customer")]
    internal class Customer : Person
    {
        public SaleRegistration Sale { get; set; } = null!;
    }
}
