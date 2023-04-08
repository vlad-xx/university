namespace Task
{
    internal class Program
    {
        static int[,] SetMatrix(int rowsNum, int colsNum)
        {
            int[,] matrix = new int[rowsNum, colsNum];

            Random randNum = new Random();

            int num;
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    num = randNum.Next(-10, 10);
                    matrix[i, j] = num;
                }
            }

            return matrix;
        }


        /* получить элементы удов условию: 
           Среди элементов, расположенных выше побочной диагонали матрицы R(6,6)
           найти те элементы, 
           которые удовлетворяют условию K2 <= Rij <= K1 (K1, K2 - произвольные числа), 
           и сформировать из них одномерный массив */
        static int[] GetEl(int[,] matrix, int k1, int k2)
        {
            int rowsNum = matrix.GetLength(0);
            int colsNum = matrix.GetLength(1);

            int n = rowsNum - 1;
            int length = 0;
            // кол-во элементов удов условию
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    if (i + j < n)
                    {
                        if (matrix[i, j] <= k1 && k2 <= matrix[i, j])
                        {
                            length++;
                        }
                    }
                }
            }
            int[] arr = new int[length];


            int l = 0;
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    if (i + j < n)
                    {
                        if (matrix[i, j] <= k1 && k2 <= matrix[i, j])
                        {
                            arr[l] = matrix[i, j];
                            l++;
                        }
                    }
                }
            }

            return arr;
        }


        // вывод матрицы на экран
        static void Show2DMatrix(int[,] matrix)
        {
            string rowString = "";
            var lengthRow = 0;
            string delim;
            int rowsNum = matrix.GetLength(0);
            int colsNum = matrix.GetLength(1);

            Console.WriteLine("Matrix Params:\n\trow = {0};\n\tcolumn = {1};", rowsNum, colsNum);

            for (int i = 0; i < rowsNum; i++)
            {
                rowString = "";
                for (int j = 0; j < colsNum; j++)
                {
                    rowString += $"{matrix[i, j],4}{"",-4}| ";
                }
                lengthRow = rowString.Length;
                delim = string.Join("", Enumerable.Repeat("-", lengthRow));
                Console.Write(delim + "\n|" + rowString + "\n");
            }
            delim = string.Join("", Enumerable.Repeat("-", lengthRow));
            Console.WriteLine(delim);
        }


        static void Main(string[] args)
        {
            int[,] matrix = SetMatrix(8, 8);
            Show2DMatrix(matrix);
            Console.WriteLine(
                "Элементы, расположенные выше побочной диагонали матрицы, которые удовлетворяют условию -5 <= Rij <= 5: {0}",
                string.Join(", ", GetEl(matrix, 5, -5))
            );
        }
    }
}