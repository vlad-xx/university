class Program {


    // поиск подстроки
    public static string SearchSubstring(string str, string substr)
    {
        // обрезание пробелов
        string newSubstr = substr.Trim(' ');

        // проверка искомой подстроки
        if (newSubstr == "")
            return str;

        newSubstr = ""; // переменная будет хранить подстрку в том виде как она записана в строке

        int lengthSubstring = substr.Length; // длина строки
        string newStr = ""; // переменная будет хранить строку с выделенными подстрочками

        int match = 0; // переменая будет хранить кол-во совпадающих символов
        int index = 0;
        while (index < str.Length)
        {
            // проверка совпадений
            if (match == lengthSubstring)
            {
                // добавление найденной подстроки в строку
                newStr += $"[{newSubstr}]"; 


                match = 0;
                newSubstr = "";
            }
            else
            {
                // сравнение символов в нижнем регистре
                if (str[index].ToString().ToLower() == substr[match].ToString().ToLower())
                {
                    match++;

                    // запись подстроки с учетом регистра как в строке
                    newSubstr += str[index];
                }
                else
                {

                    index -= match; // если совпадение не установленно возврат к прошлому символу/слову

                    match = 0;
                    newSubstr = "";

                    // запись символов в новую строку
                    newStr += str[index];
                }
                index++;
            }

        }

        return newStr;
    }


    static void Main() 
    {
        string str = "Задача организации, в особенности же консультация с профессионалами из IT " +
            "требует от нас системного анализа дальнейших направлений развитая системы массового участия! " +
            "Разнообразный и богатый опыт постоянное информационно-техническое обеспечение нашей " +
            "деятельности требует определения и уточнения позиций, занимаемых участниками в " +
            "отношении поставленных задач! Равным образом постоянный количественный рост и " +
            "сфера нашей активности...";

        Console.WriteLine(str);
        Console.WriteLine("\nВведите строку для поиска");
        string substring = $"{Console.ReadLine()}";
        Console.WriteLine(SearchSubstring(str, substring));
    }
}