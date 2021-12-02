using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixToStairs.Apps
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(3, 3);
            Console.WriteLine(matrix);
            matrix.ToStairs();
            Console.WriteLine(matrix);
            Console.ReadKey();
        }
    }
}
