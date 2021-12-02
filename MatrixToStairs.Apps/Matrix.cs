using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixToStairs.Apps
{
    class Matrix
    {
        private int rows;
        private int colls;
        private double[,] value;
        public int Rows => rows;
        public int Colls => colls;

        public Matrix(int r, int c)
        {
            rows = r;
            colls = c;
            value = new double[rows, colls];
            MatrixRandom();
        }
        public Matrix(double[,] arr)
        {
            value = arr.Clone() as double[,];
            rows = arr.GetLength(0);
            colls = arr.GetLength(1);
        }


        private void MatrixRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    value[i, j] = rnd.Next(1, 30);
                }
            }
        }

        public void ToStairs()
        {
            if(value[0,0] != 1 || value[0,0] != -1)
            {
                SwapColls();
            }
            for(int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    double z = value[j, i] / value[i, i];
                    for (int k = 0; k < colls; k++) 
                    {
                        value[j, k] -= value[i, k] * z;
                    }
                }
            }
            ValueCheck();
            
        }
        private void SwapColls()
        {
            double slave = 0;
            for (int i = 1; i < rows; i++)
            {
                if (value[i, 0] == 1 || value[i, 0] == -1) 
                {
                    for (int j = 0; j < colls; j++)
                    {
                        slave = value[0, j];
                        value[0, j] = value[i, j];
                        value[i, j] = slave;
                    }
                    break;
                }
            }
            if (slave == 0)
            {
                double x = value[0, 0];
                for (int i = 0; i < colls; i++)
                {
                    value[0, i] /= x;
                }
            }
        }
        private void ValueCheck()
        {
            for(int i = 0; i < rows && i < colls; i++)
            {
                if(value[i,i] == 1 || value[i,i] == -1)
                {
                    continue;
                }
                else
                {
                    if (i == colls - 1)
                    {
                        if (value[i, i] > value[i - 1, i] || -value[i,i] > value[i - 1, i])
                        {
                            double g = (value[i, i] - 1) / value[i - 1, i];
                            value[i, i] -= value[i - 1, i] * g;
                        }
                        else
                        {
                            double g = (value[i,i] + 1) / value[i - 1, i];
                            value[i, i] -= value[i - 1, i] * g;
                        }
                    }
                    else
                    {
                        double v = value[i, i];
                        for (int j = i; j < colls; j++)
                        {
                            value[i, j] /= v;
                        }
                    }

                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colls; j++)
                {
                    sb.Append($" {value[i, j]} \t");
                    if (j == colls - 1)
                    {
                        sb.Append("");
                    }
                    else
                    {
                        sb.Append("|");
                    }
                }
                sb.AppendLine();
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
