// First In First Out - Первый пришел, первый вышел
// Очередь - queue

class Program
{
 
    // добавление в очередь
    public static void Enqueue(List<int> list, int el)
    {
        list.Add(el); // добавление элемента в конец
        Console.WriteLine($"Добавление в очередь: {el}");
        Console.WriteLine($"Очередь: {string.Join(", ", list)}\n");
    }


    // удаление из очереди
    public static int Dequeue(List<int> list)
    {
        int el = -1;
        // если список не пустой
        if (list.Count != 0)
        {
            // первый элемент
            el = list[0];
            Console.WriteLine($"Удаление из очереди: {el}");

            // удаление первого элемента
            list.RemoveAt(0);
            Console.WriteLine($"Очередь: {string.Join(", ", list)}\n");
        }
        else 
        {
            Console.WriteLine("В очереди отсутствуют элементы\n");
        }
        return el;
    }


    static void Main()
    {
        // есть пустой список принимающий числа
        List<int> nums = new();

        Enqueue(nums, 11);
        Enqueue(nums, 56);
        Enqueue(nums, 90);
        Enqueue(nums, 101);

        Dequeue(nums);
        Dequeue(nums);

        Enqueue(nums, 34);
        Dequeue(nums);

        Dequeue(nums);
        Dequeue(nums);
        Dequeue(nums);

    }
}