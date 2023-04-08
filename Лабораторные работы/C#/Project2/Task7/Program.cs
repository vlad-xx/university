namespace Task
{
    internal class Program
    {
        // создание массива
        static ushort[] CreateArr(ushort length)
        {
            // массив uint16 чисел с неполным набором значений
            ushort[] arr = new ushort[length];

            // рандомное число не входящее в массив
            Random randNum = new Random();
            ushort numException = Convert.ToUInt16(randNum.Next(0, length + 1));

            // число добавляемое в массив
            ushort num = 0;
            // наполнение массива числами
            for (ushort i = 0; i < length; i++)
            {
                if (num == numException)
                    num++;
                arr[i] = num;
                num++;
            }

            return arr;
        }


        // поиск недостающего числа
        static void SearchNumException(ushort[] arr, ushort maxValue)
        {
            if (arr.Last() != maxValue)
            {
                Console.WriteLine($"Число найдено: {maxValue}");
            }
            else
            {
                for (ushort i = 0; i < maxValue; i++)
                {
                    if (arr[i] != i)
                    {
                        Console.WriteLine($"Число найдено: {i}");
                        break;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            // ushort - uint16, хранит от 0 до 65535
            // максимальное значение uint16
            ushort maxValue = ushort.MaxValue;
            ushort[] arr = CreateArr(maxValue);
            Console.WriteLine("Массив наполнен\nОдного числа не хватает\nПоиск недостающего числа");
            SearchNumException(arr, maxValue);
        }
    }
}