using System;
using System.Collections.Generic;
using System.Text;

namespace FillTest
{
    public static class TestArrea
    {
        public static byte[] CreateRect(int width, int height)
        {
            var result = new byte[width * height];

            var rw = width / 2;
            var rh = height / 2;

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 255;
            }

            for (int y = 0; y < rh; y++)
            {
                for (int x = 0; x < rw; x++)
                {
                    result[width / 4 + x + (y + height / 4) * height] = 0;
                }
            }

            return result;
        }
        public static byte[] CreateEmpty(int width, int height)
        {
            var result = new byte[width * height];
            return result;
        }
    }
}
