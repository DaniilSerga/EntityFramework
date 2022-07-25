using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Model.DatabaseModels
{
    [Table("Employees")]
    internal class Employee : Person
    {
        public decimal Salary { get; set; }

        public int PositionId { get; set; }

        public int StoreId { get; set; }

        public Position Position { get; set; } = null!;

        public Store? Store { get; set; }
    }
}
