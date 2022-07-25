using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Model.DatabaseModels
{
    [Table("Customer")]
    internal class Customer : Person
    {
        public SaleRegistration Sale { get; set; } = null!;
    }
}
