﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.TypesAndOperators
{
    public record Pet(string name)
    {
        public void ShredTheFurniture()
        {
            Console.WriteLine("Shredding furniture");
        }
    }

    public record Dog(string name) : Pet(name)
    {
        public void WagTail()
        {
            Console.WriteLine("It's tail wagging time");
        }

        public override string ToString()
        {
            StringBuilder s = new();
            base.PrintMembers(s);
            return $"{s.ToString()} is a dog";
        }
    }
}
