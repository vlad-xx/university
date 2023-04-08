class Program
{

    // получить массив случайных чисел 
    public static int[] GetRandArray(int lengthArray, int rFrom, int rTo)
    {
        List<int> listNums = new();

        while (listNums.Count < lengthArray)
        {
            int num = new Random().Next(rFrom, rTo);
            /*if (!listNums.Contains(num))*/
            listNums.Add(num);
        }

        return listNums.ToArray();
    }
    

    // показать массив
    public static void ShowArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]}[{i}] ");
        }
    }


    // прочитать число
    public static int ReadNum()
    {
        Console.Write("\nВведите число: ");
        return Convert.ToInt32(Console.ReadLine());
    }


    // поиск индекса числа
    public static int SearchIndex(int[] arr, int num)
    {
        int length = arr.Length;
        if (length == 0)
            return 0;

        int midIndex;
        if (length % 2 != 0)
            midIndex = (length+1) / 2;
        else
            midIndex = length / 2;

        int curIndex = 0;

        while (curIndex < midIndex)
        {
            /*Console.WriteLine(curIndex);*/
            if (arr[curIndex] == num)
                return curIndex;
            curIndex++;
        }
        
        while (curIndex < length)
        {
            /*Console.WriteLine(curIndex)*/;
            if (arr[curIndex] == num)
                return curIndex;
            curIndex++;
        }

        return -1;
    }


    static void Main()
    {
        int[] arr = GetRandArray(100, 0, 100);
        ShowArray(arr);
        int num = ReadNum();
        int index = SearchIndex(arr, num);
        string result = "Индекс искомого элемента";
        if (index == -1)
            result += " не найден";
        else
            result += $": {index}";

        Console.WriteLine(result);
    }
}