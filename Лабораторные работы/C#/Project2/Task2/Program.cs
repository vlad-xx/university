class Program
{
    // массив случайных чисел
    static int[] RandomArr(int length)
    {
        int[] arr = new int[length];

        Random randNum = new Random();
        int num;
        for (int i = 0; i < length; i++)
        {
            num = randNum.Next(-1000, 1000);
            arr[i] = num;
        }

        return arr;
    }


    // наименьшее и наибольшее число в массиве 
    static int[] MinMaxNumsInArr(int[] arr)
    {
        int minNum = arr[0];
        int maxNum = arr[0];
        int[] arrMinMaxNums = new int[2];
        foreach (int num in arr)
        {
            if (minNum > num)
            {
                minNum = num;
            }
            if (maxNum < num)
            {
                maxNum = num;
            }
        }
        arrMinMaxNums[0] = minNum;
        arrMinMaxNums[1] = maxNum;

        return arrMinMaxNums;
    }

    // замена чисел
    static int[] ChangeNums(int[] arr, int[] arrMinMaxNums)
    {
        int[] newArr = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            if (arrMinMaxNums[0] == arr[i])
            {
                newArr[i] = -1;
            }
            else if (arrMinMaxNums[1] == arr[i])
            {
                newArr[i] = 1;
            }
            else
            {
                newArr[i] = arr[i];
            }
        }

        return newArr;
    }

    static void Main(string[] args)
    {
        int[] arr = RandomArr(11);
        Console.WriteLine("Array: {0}", string.Join(", ", arr));
        Console.WriteLine("NewArray: {0}", string.Join(", ", ChangeNums(arr, MinMaxNumsInArr(arr))));
    }
}
