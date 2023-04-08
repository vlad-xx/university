using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        public static List<int> ListNums(int count) // запрашивает у пользователя желаемое кол-во чисел и возвращет список введенных чисел
        {
            int num; // переменная в которой будут храниться по очередно вводимые числа
            int i = 1; // номер вводимого числа
            List<int> listNums = new List<int>(count); // список в котором будут храниться числа
            while (listNums.Count < count) // пока длина списка не равна желаемому кол-ву чисел
            {
                try // пытаемся привести введенное число к типу данных int
                {
                    Console.Write("Введите {0}-е число: ", i);
                    num = Convert.ToInt32(Console.ReadLine()); // присваеваем переменной введенное число и преобразуем в тип данных int
                }
                catch (FormatException) // если поймана ошибка при попытке преобразовать число
                {
                    Console.WriteLine("Ожидается число...");
                    continue; // цикл запускается заново
                }
                listNums.Add(num); // добавляем введенное число в список
                i++; // номер следующего числа

            }
            return listNums; // возращается список
        }

        public static List<int> ListRandomNums(int count) // рандомный список чисел
        {
            Random randNum = new Random(); // cоздание объекта для генерации чисел
            int num;
            List<int> listRandomNums = new List<int>(count); // список в котором будут храниться числа
            while (listRandomNums.Count < count) // пока длина списка не равна желаемому кол-ву чисел
            {
                num = randNum.Next(0, 10000);
                listRandomNums.Add(num); // добавляем введенное число в список
            }
            Console.WriteLine(string.Join(", ", listRandomNums));
            return listRandomNums; // возращается список
        }

        public static void SearchDuplicatesMaxMinNums(List<int> list, List<int> list2) 
        {
            int count = 0; // переменная для хранения кол-ва дубликатов
            list.Sort(); // сортируем список
            
            foreach (int num in list2) // перебираем список неповторяющихся чисел и каждое присваеваем переменной num 
            { 
                foreach (int num2 in list) // перебираем список чисел и каждое присваеваем переменной num2
                {
                    if (num == num2) // если числа из списков равны
                        count++; // увеличиваем кол-во дубликатов
                }
                Console.WriteLine("Число {0} повторяется {1} раз(а)", num, count); // сообщаем пользователю информацию о дубликатах
                count = 0; // обнуляем кол-во дубликатов, чтобы посчитать дубликаты следующих чисел в списке
            }
        }
        
        /* поиск максимального и минимального числа*/   
        public static List<int> SearchMaxMinNums(List<int> list)
        {
            List<int> listMaxMinNums = new List<int>(2);
            list.Sort(); // сортируем список
            
            if (list[0] != list[list.Count - 1]){
                listMaxMinNums.Add(list[0]);
                listMaxMinNums.Add(list[list.Count - 1]);

                System.Console.WriteLine("Минимальное число: {0}", listMaxMinNums[0]);
                System.Console.WriteLine("Максимальное число: {0}", listMaxMinNums[1]);
            }else{
                listMaxMinNums.Add(list[0]);

                System.Console.WriteLine("Минимальное и максимальное число: {0}", listMaxMinNums[0]);
            }
            return listMaxMinNums;
        }

        static void Main(string[] args)
        {
            /*
            Cлучайным образом задается четыре целых числа 
            затем определяется максимальное и минимальное число, 
            также находится количество максимальных и минимальных чисел среди введенных. 
            */
            SearchMaxMinNums(ListRandomNums(4));
            List<int> listNums = ListNums(4);
            SearchDuplicatesMaxMinNums(listNums, SearchMaxMinNums(listNums));
        }
    }
}
