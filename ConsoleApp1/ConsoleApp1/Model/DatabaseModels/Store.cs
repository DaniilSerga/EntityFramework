﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.DatabaseModels
{
    internal class Store
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<City> Cities { get; set; } = new();

        public List<Employee> Employees { get; set; } = new();
    }
}
