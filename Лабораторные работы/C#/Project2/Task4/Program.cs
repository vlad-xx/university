namespace Task
{
    internal class Program
    {
        // row - строка
        // col - столбец

        static object[,] SetMatrix(int rowsNum, int colsNum)
        {
            object[,] matrix = new object[rowsNum, colsNum];

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


        // newEl - новый элемент на который будут заменены четные строки
        static object[,] ChangeElOfMatrix(object[,] matrix, char newEl)
        {
            int rowsNum = matrix.GetLength(0);
            int colsNum = matrix.GetLength(1);
            object[,] newMatrix = new object[rowsNum, colsNum];

            for (int i = 0; i < rowsNum; i++)
            {
                for (int j = 0; j < colsNum; j++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        newMatrix[i, j] = newEl;
                    }
                    else
                    {
                        newMatrix[i, j] = matrix[i, j];
                    }
                }
            }

            return newMatrix;
        }


        static void Show2DMatrix(object[,] matrix)
        {
            string rowSrting = "";
            var lengthRow = 0;
            string delim;
            int rowsNum = matrix.GetLength(0);
            int colsNum = matrix.GetLength(1);

            Console.WriteLine("Matrix Params:\n\trow = {0};\n\tcolumn = {1};", rowsNum, colsNum);

            for (int i = 0; i < rowsNum; i++)
            {
                rowSrting = "";
                for (int j = 0; j < colsNum; j++)
                {
                    rowSrting += $"{matrix[i, j],4}{"",-4}| ";
                }
                lengthRow = rowSrting.Length;
                delim = string.Join("", Enumerable.Repeat("-", lengthRow));
                Console.Write(delim + "\n|" + rowSrting + "\n");
            }
            delim = string.Join("", Enumerable.Repeat("-", lengthRow));
            Console.WriteLine(delim);
        }


        static void Main(string[] args)
        {
            object[,] matrix = SetMatrix(8, 3);
            Show2DMatrix(matrix);
            Console.WriteLine("\nЗаменяем четные строки  матрицы на 'H'");
            Show2DMatrix(ChangeElOfMatrix(matrix, 'H'));
        }
    }
}