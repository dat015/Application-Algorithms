using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap01
{
    public static class bai33
    {
        public static double dot(double[] x, double[] y)
        {
            if (x.Length != y.Length) throw new ArgumentException("Vectors must be the same length.");
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i] * y[i];
            }
            return sum;
        }

        public static double[][] mult(double[][] a, double[][] b)
        {
            int rowsA = a.Length, colsA = a[0].Length, rowsB = b.Length, colsB = b[0].Length;
            if (colsA != rowsB) throw new ArgumentException("Matrix dimensions are not compatible for multiplication.");

            double[][] product = new double[rowsA][];
            for (int i = 0; i < rowsA; i++)
            {
                product[i] = new double[colsB];
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                    {
                        product[i][j] += a[i][k] * b[k][j];
                    }
                }
            }
            return product;
        }

        public static double[][] transpose(double[][] a)
        {
            int rows = a.Length, cols = a[0].Length;
            double[][] transposed = new double[cols][];
            for (int i = 0; i < cols; i++)
            {
                transposed[i] = new double[rows];
                for (int j = 0; j < rows; j++)
                {
                    transposed[i][j] = a[j][i];
                }
            }
            return transposed;
        }

        public static double[] mult(double[][] a, double[] x)
        {
            int rows = a.Length, cols = a[0].Length;
            if (cols != x.Length) throw new ArgumentException("Matrix and vector dimensions are not compatible for multiplication.");

            double[] product = new double[rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    product[i] += a[i][j] * x[j];
                }
            }
            return product;
        }

        public static double[] mult(double[] y, double[][] a)
        {
            int rows = a.Length; 
            int cols = a[0].Length; 

            if (y.Length != cols) throw new ArgumentException("Vector and matrix dimensions are not compatible for multiplication.");

            double[] product = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                product[i] = 0; 
                for (int j = 0; j < cols; j++)
                {
                    product[i] += a[i][j] * y[j]; 
                }
            }
            return product;
        }
    }
}
