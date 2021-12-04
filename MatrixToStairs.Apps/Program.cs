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
            Matrix matrix = new Matrix(new double[,]
            {
                {5,2,56 },
                {2,0,2.5 },
                {2,5,63 },
                {0,5,0 }
            });

            Console.WriteLine(matrix);
            matrix.ToStairs();

            Console.WriteLine(matrix);
            Console.ReadLine();

        }
    }
}
