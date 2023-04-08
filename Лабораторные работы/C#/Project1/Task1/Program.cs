using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
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

        public static void SearchDuplicates(List<int> list) // поиск дубликатов в списке чисел
        {
            int count = 0; // переменная для хранения кол-ва дубликатов
            list.Sort(); // сортируем список
            var listUnicNums = list.Distinct(); // преобразуем список чисел в список неповторяющихся чисел (не индексируется)
            foreach (int num in listUnicNums) // перебираем список неповторяющихся чисел и каждое присваеваем переменной num 
            { 
                foreach (int num2 in list) // перебираем список чисел и каждое присваеваем переменной num2
                {
                    if (num == num2) // если числа из списков равны
                        count++; // увеличиваем кол-во дубликатов
                }
                if (count > 1) // если кол-во дубликатов числа больше 1
                {
                    Console.WriteLine("Число {0} повторяется {1} раз(а)", num, count); // сообщаем пользователю информацию о дубликатах
                }
                count = 0; // обнуляем кол-во дубликатов, чтобы посчитать дубликаты следующих чисел в списке
            }
        }

        public static void Main(string[] args)
        {
            /*
             * запрашиваем у пользователя желаемое кол-во чисел и возвращем список введенных чисел
             * ищем дубликаты чисел в списке            
             */
            SearchDuplicates(ListNums(4)); 
        }
    }
}
