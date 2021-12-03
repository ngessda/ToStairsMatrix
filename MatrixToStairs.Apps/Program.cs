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
                {0,0,0,0 },
                {2,1,0,1 },
                {0,5,1,4 }
            });
            Console.WriteLine(matrix);
            matrix.ToStairs();
            Console.WriteLine(matrix);
            Console.ReadLine();
        }
    }
}
