﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es06_10_03
{
    class FinallyClause
    {
        public void MethodA()
        {
            try
            {
                Console.WriteLine("1");
            }
            catch (Exception e)
            {
                Console.WriteLine("2");
            }
        }
        public void MethodB()
        {
            try
            {
                Console.WriteLine("3");
            }
            finally
            {
                Console.WriteLine("4");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FinallyClause fc = new FinallyClause();
            fc.MethodA();
            fc.MethodB();
        }
    }
}
