namespace Task
{
    internal class Program
    {
        // задать матрицу
        static int[,] SetMatrix2D(int rowsNum, int colsNum, int k)
        {
            int[,] matrix = new int[rowsNum, colsNum];

            Random randNum = new Random();
            int count = k; // кол-во единиц
            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    if (count > 0)
                    {
                        matrix[i, j] = randNum.Next(0, 2);
                        if (matrix[i, j] == 1)
                            count--;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            if (count != 0)
            {
                Console.WriteLine("Перезапись матрицы");
                matrix = SetMatrix2D(rowsNum, colsNum, k);
            }

            return matrix;
        }


        // вывод матрицы в консоль
        static void Show2DMatrix(int[,] matrix)
        {
            int rowsNum = matrix.GetLength(0); // кол-во столбцов в матрице
            int colsNum = matrix.GetLength(1); // кол-во строк в матрице
                                               // Console.WriteLine("{0}, {1}", col, row);

            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }


        // вывод картинки
        static void Show2DMatrixPic(int[,] matrix)
        {
            int rowsNum = matrix.GetLength(0); // кол-во столбцов в матрице
            int colsNum = matrix.GetLength(1); // кол-во строк в матрице
                                               // Console.WriteLine("{0}, {1}", col, row);

            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    if (matrix[i, j] == 0)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        // вывод матрицы по всем направлениям
        static int[,] MatrixReflection(int[,] matrix)
        {
            int rowsNum = matrix.GetLength(0); // кол-во строк в матрице
            int colsNum = matrix.GetLength(1); // кол-во столбцов в матрице
            int[,] newMatrix = new int[rowsNum * 2, colsNum * 2]; // новая матрица
                                                                  // Console.WriteLine("{0}, {1}", col, row);

            Console.WriteLine();
            for (int i = 0; i < rowsNum; i++)
            {
                // без отражения
                for (int j = 0; j < colsNum; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                    Console.Write($"{newMatrix[i, j]} ");
                }
                Console.Write("|"); // разделитель по вертикали
                                    // отражение строк
                for (int j = 0; j < colsNum; j++)
                {
                    newMatrix[i, colsNum + j] = matrix[i, colsNum - 1 - j];
                    Console.Write($"{newMatrix[i, colsNum + j]} ");
                }
                Console.WriteLine();
            }
            // разделитель по горизонтали
            for (int i = 0; i <= rowsNum * 2; i++)
            {
                Console.Write("--");
            }
            Console.WriteLine();
            for (int i = 0; i < rowsNum; i++)
            {
                // отражение столбцов
                for (int j = 0; j < colsNum; j++)
                {
                    newMatrix[rowsNum + i, j] = matrix[rowsNum - 1 - i, j];
                    Console.Write($"{newMatrix[rowsNum + i, j]} ");
                }
                Console.Write("|"); // разделитель по вертикали
                                    // отражение столбцов и строк
                for (int j = 0; j < colsNum; j++)
                {
                    newMatrix[rowsNum + i, colsNum + j] = matrix[rowsNum - 1 - i, colsNum - 1 - j];
                    Console.Write($"{newMatrix[rowsNum + i, colsNum + j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            return newMatrix;
        }


        static void Main(string[] args)
        {
            int n = 0;
            while (n <= 0)
            {
                Console.Write("Введите кол-во строк (больше 0): ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ожидается число");
                    continue;
                }
            }

            int m = 0;
            while (m <= 0)
            {
                Console.Write("Введите кол-во столбцов (больше 0): ");
                try
                {
                    m = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ожидается число");
                    continue;
                }
            }

            int k = 0;
            int maxNum = (n * m) / 2;
            while (k <= 0 || k > maxNum)
            {
                Console.Write($"Введите кол-во единиц (больше 0 и не больше половины размера матрицы - {maxNum}): ");
                try
                {
                    k = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ожидается число");
                    continue;
                }
            }

            Console.WriteLine($"n = {n}; m = {m}; k = {k}");
            int[,] matrix = SetMatrix2D(n, m, k);
            Show2DMatrix(matrix);
            int[,] newMatrix = MatrixReflection(matrix);
            Show2DMatrixPic(newMatrix);
        }
    }
}