﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day7;

namespace UnitTestProject1
{
    [TestClass]
    public class Day7_Tests
    {

        [TestMethod]
        public void P1()
        {
            string filePath = "day7-2018-test.txt";
            List<string> lines = Program.ReadTextIntoLines(filePath);
            Program.Part1(lines);
        }

     
       
    }
}
