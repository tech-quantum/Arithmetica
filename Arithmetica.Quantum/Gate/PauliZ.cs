﻿using Arithmetica.LinearAlgebra.Single;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetica.Quantum.Gate
{
    public class PauliZ : QuantumGate
    {
        public PauliZ() : base("Z")
        {
            Matrix = new Complex[,] {
                    { 1, 0 },
                    { 0, -1 },
                };
        }
    }
}