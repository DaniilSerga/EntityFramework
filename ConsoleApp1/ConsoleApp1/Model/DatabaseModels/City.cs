using System.Collections.Generic;

namespace ConsoleApp1.Model.DatabaseModels
{
    internal class City
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<Store> Stores { get; set; } = new();
    }
}
