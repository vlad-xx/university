
using System;


namespace WindowsFormsApp1
{


    /// <summary>
    /// работа с методами сортировки
    /// </summary>
    class MethodsSort {


        /// <summary>
        /// получить массив случаных чисел из диапазона
        /// </summary>
        /// <param name="len">желаемая длина массива</param>
        /// <param name="from">начало диапазона</param>
        /// <param name="to">конец диапазона (это число не входит в массив)</param>
        /// <returns>массив случаных чисел из диапазона</returns>
        public static int[] getRandomArr(int len, int from, int to)
        {
            // задается список уникальных случайных чисел из диапазона
            int[] arr = new int[len];
            Random randNum = new Random();
            for (int i = 0; i < len; i++)
                arr[i] = randNum.Next(from, to);

            return arr;
        }


        /// <summary>
        /// сортировка методом пузырька
        /// </summary>
        /// <param name="arr">сортируемый массив</param>
        public static void bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // сравнение элементов
                    if (arr[i] > arr[j])
                    {
                        // обмен элементов
                        int buf = arr[i];
                        arr[i] = arr[j];
                        arr[j] = buf;
                    }
                }
            }
        }


        /// <summary>
        /// сортировка методом прямого включения
        /// </summary>
        /// <param name="arr">сортируемый массив</param>
        public static void insertionSort(int[] arr)
        {

            // buf // временная переменная для хранения значения элемента сортируемого массива
            // item // индекс предыдущего элемента
            for (int i = 1; i < arr.Length; i++)
            {
                int buf = arr[i]; // инициализируем временную переменную текущим значением элемента массива
                int item = i - 1; // запоминаем индекс предыдущего элемента массива
                while (item >= 0 && arr[item] > buf) // пока индекс не равен 0 и предыдущий элемент массива больше текущего
                {
                    arr[item + 1] = arr[item]; // перестановка элементов массива
                    arr[item] = buf;
                    item--;
                }
            }
        }


        /// <summary>
        /// сортировка методом прямого выбора
        /// </summary>
        /// <param name="arr">сортируемый массив</param>
        public static void selectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // поиск минимального числа
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                // обмен элементов
                int buf = arr[min];
                arr[min] = arr[i];
                arr[i] = buf;
            }
        }


        /// <summary>
        /// сортировка методом шейкера
        /// </summary>
        /// <param name="arr">сортируемый массив</param>
        public static void shakerSort(int[] arr)
        {
            for (var i = 0; i < arr.Length / 2; i++)
            {
                var swapFlag = false;
                //проход слева направо
                for (var j = i; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapFlag = true;
                    }
                }

                //проход справа налево
                for (var j = arr.Length - 2 - i; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        var temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        swapFlag = true;
                    }
                }

                //если обменов не было выходим
                if (!swapFlag)
                {
                    break;
                }
            }

        }



        /// <summary>
        /// сортировка методом шелла
        /// </summary>
        /// <param name="arr">сортируемый массив</param>
        public static void shellSort(int[] arr)
        {
            int buf;
            int n = arr.Length;
            for (int step = n / 2; step > 0; step /= 2)
            {
                for (int i = step; i < n; i++)
                {
                    buf = arr[i];
                    int j;
                    for (j = i; j >= step; j -= step)
                    {
                        if (buf < arr[j - step])
                            arr[j] = arr[j - step];
                        else
                            break;
                    }
                    arr[j] = buf;
                }
            }
        }


        /// <summary>
        /// сортировка методом хоара
        /// </summary>
        /// <param name="arr">сортируемый массив</param>
        /// <param name="leftIndex">начало массива</param>
        /// <param name="rightIndex">конец массива</param>
        public static void quickSort(int[] arr, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = arr[leftIndex];
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                quickSort(arr, leftIndex, j);
            if (i < rightIndex)
                quickSort(arr, i, rightIndex);
            
        }
    }
}
