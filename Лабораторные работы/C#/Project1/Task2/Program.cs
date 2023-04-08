using System;
using System.Collections.Generic;
using System.Linq;
\
namespace Task2
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

        /* поиск наибольшего числа 
        (принимает список чисел и индекс числа по величине, которое нужно найти)*/   
        public static void SearchMaxNum(List<int> list, int iNum)
        {
            list.Sort(); // сортируем список
            /*преобразуем список чисел в список неповторяющихся чисел (не индексирутся), 
            преобразуем cонова в список*/
            var listUnicNums = list.Distinct().ToList(); 
            if (listUnicNums.Count >= iNum)
            {
                System.Console.WriteLine("{0}-е по величине число: {1}", iNum, listUnicNums[iNum - 1]);
            }else{
                System.Console.WriteLine("{0}-е по величине число: не существует", iNum);
            }
        }

        static void Main(string[] args)
        {
            /*
            Запрашиваем у пользователя четыре целых числа 
            и затем находим третье по величине число, если оно существует. 
            */
            SearchMaxNum(ListNums(4), 3);
        }
    }
}
