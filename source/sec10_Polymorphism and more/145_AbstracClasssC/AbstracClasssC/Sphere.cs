﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracClasssC
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double rasius)
        {
            Name = "Sphere";
            Radius = rasius;
        }

        public override double Volume()
        {
            return (Math.PI * Math.Pow(Radius, 3)) * 4 / 3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The Sphere has a radius of {Radius}");
        }
    }
}
