﻿using Day12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Program
    {
        public static void Main(string[] args)
        {
            string initialState = "#..#.#..##......###...###";
            string rulesFileName = "day12-p1-2018.txt";
            PotRow potRow = new PotRow(initialState, rulesFileName);

            potRow.ApplyRules();
        }
    }
}
