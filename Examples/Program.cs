﻿using System;
using Arithmetica.Geometry2D;
using Arithmetica.LinearAlgebra.Single;
using NumSharp;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Global.UseAmplifier(0);
            new Basics().Run();

            Console.ReadLine();
        }
    }
}
