using System;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace FillTest
{
    public class Benchmarks
    {
        [Benchmark]
        public int[] ShaganovTest()
        {
            var width = 2048;
            var height = 2048;
            var emptyPoints = TestArrea.CreateEmpty(width, height);
            var rectPoints = TestArrea.CreateRect(width, height);
            int startX = width / 2;
            int startY = height / 2;
            byte trashold = 255;
            var shaganovTest = new ShaganovTest();
            var image = shaganovTest.GetArea(emptyPoints, trashold, startX, startY, width, height);
            return image;
        }

        [Benchmark]
        public int[] Shaganov2()
        { var width = 2048;
            var height = 2048;
            var emptyPoints = TestArrea.CreateEmpty(width, height);
            var rectPoints = TestArrea.CreateRect(width, height);
            int startX = width / 2;
            int startY = height / 2;
            byte trashold = 255;
            var shaganovTest = new ShaganovTest();
            var image = shaganovTest.GetArea(rectPoints, trashold, startX, startY, width, height);
            return image;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var tests = BenchmarkRunner.Run<Benchmarks>();

         
            
        }
        
    }
}
