class Program
{
    // перевернуть массив
    public static int[] FlipArray(int[] arr)
    {
        int[] arr1 = new int[arr.Length];
        int j = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr1[j] = arr[i];
            j++;
        }
        return arr1;
    }


    void Main()
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine(string.Join(", ", FlipArray(arr)));
    }
}