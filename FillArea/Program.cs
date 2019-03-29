using System;
using System.Diagnostics;

namespace FillTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = 2048;
            var height = 2048;
            var emptyPoints = TestArrea.CreateEmpty(width, height);
            var rectPoints = TestArrea.CreateRect(width, height);
            int startX = width / 2;
            int startY = height / 2;
            byte trashold = 255;

            var st = new Stopwatch();
            var shaganovTest = new ShaganovTest();

            //Test 1
            {
                st.Start();
                var image = shaganovTest.GetArea(emptyPoints, trashold, startX, startY, width, height);
                st.Stop();
                var ts = st.Elapsed;
                var resultShaganov = "Result EMPTY Shaganov:" + string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                Console.WriteLine(resultShaganov);
                Image.SaveImage("sahanov_empty", image, width, height);
            }
            st.Reset();
            //Test 2
            {
                st.Start();
                var image = shaganovTest.GetArea(rectPoints, trashold, startX, startY, width, height);
                st.Stop();
                var ts = st.Elapsed;
                var resultShaganov = "Result RECT Shaganov:" + string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                
                Console.WriteLine(resultShaganov);
                Image.SaveImage("sahanov_rect", image, width, height);
            }



            Console.ReadKey();
        }
        
    }
}
