﻿using BenchmarkDotNet.Running;
using System;

namespace BenchmarkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<OriginTest>();
            Console.ReadKey();
        }
    }
}