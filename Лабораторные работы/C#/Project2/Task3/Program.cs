namespace Task
{
    internal class Program
    {
        static int[] RandomArr(int length)
        {
            int[] randArr = new int[length];

            Random randNum = new Random();

            int num;
            for (int i = 0; i < length; i++)
            {
                num = randNum.Next(-10, 10);
                randArr[i] = num;
            }

            return randArr;
        }

        // numOfEl - кол-ов элементов которые нужно обойти
        static int NumOfNegativeEl(int[] arr, int numOfEl)
        {
            int num = 0;

            for (int i = 0; i < numOfEl; i++)
            {
                if (arr[i] < 0)
                {
                    num++;
                }
            }

            return num;
        }


        static int NumOfZeroEl(int[] arr)
        {
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    num++;
                }
            }

            return num;
        }

        static void Main(string[] args)
        {
            int[] arr = RandomArr(32);
            Console.WriteLine("Элементы массива: {0}", string.Join(", ", arr));
            Console.WriteLine(
                "Кол-во отприцательный чисел среди первых 20 элементов массива: {0}",
                NumOfNegativeEl(arr, 20)
                );
            Console.WriteLine(
                "Кол-во нулевых элементов массива: {0}",
                NumOfZeroEl(arr)
                );
        }
    }
}