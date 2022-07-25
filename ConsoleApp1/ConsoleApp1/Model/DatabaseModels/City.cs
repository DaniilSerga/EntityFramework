﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.DatabaseModels
{
    internal class City
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<Store> Stores { get; set; } = new();
    }
}
