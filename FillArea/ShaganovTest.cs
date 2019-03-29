using System.Collections.Generic;
using System.Linq;


namespace FillTest
{
    class ShaganovTest : IFillTest
    {
        public int[] GetArea(byte[] points, byte trashold, int startX, int startY, int width, int heigth)
        {
            var result = new HashSet<int>();
            var visited = new HashSet<int>();
            var toVisited = new Stack<int>();

            var directions = new int[4];

            toVisited.Push(startX + startY * width);

            while (toVisited.Count > 0)
            {
                var point = toVisited.Pop();
                visited.Add(point);

                var cy = point / heigth;
                var cx = point - cy * heigth;

                directions[0] = (cx + 1) + cy * heigth;
                directions[1] = (cx - 1) + cy * heigth;
                directions[2] = point + heigth;
                directions[3] = point - heigth;

                for (int i = 0; i < 4; i++)
                {
                    var p = directions[i];
                    if (p >= 0 && p < points.Length)
                    {
                        if (points[p] < trashold)
                        {
                            if (!visited.Contains(p))
                            {
                                toVisited.Push(p);
                                result.Add(p);
                            }
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}
