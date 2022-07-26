﻿namespace ConsoleApp1.Model.DatabaseModels
{
    internal class SaleRegistration
    {
        public int Id { get; set; }

        public DateTime SaleDate { get; set; }

        public int BookId { get; set; }

        public int CustomerId { get; set; }

        public int EmployeeId { get; set; }

        public List<Book> Books { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
    }
}
