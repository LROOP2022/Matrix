using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixx
{
    public class Matrix
    {
        private int m;
        private int n;
        public int[,] numbers;
        public Matrix(int pM, int pN)
        {
            m = pM;
            n = pN;
            numbers = new int[n,m];
            Console.WriteLine("Введите значение матрицы >");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    Console.Write(matrix.numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static float[] GetSrArif(Matrix matrix)
        {
            float sum;
            float [] result = new float[matrix.n];
            for (int i = 0; i < matrix.n; i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.m; j++)
                {
                    sum+=matrix.numbers[i, j];
                }
                result[i] = sum / matrix.m;
            }
            return result;
        }

        public static void PrintResultMatrix(Matrix matrix)
        {
            float[] srArif = GetSrArif(matrix);
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    if (matrix.numbers[i, j] > srArif[i])
                    {
                        matrix.numbers[i, j] = 1;
                    }
                    else if (matrix.numbers[i, j] < srArif[i])
                    {
                        matrix.numbers[i, j] = 0;
                    }
                    Console.Write((matrix.numbers[i, j]) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
