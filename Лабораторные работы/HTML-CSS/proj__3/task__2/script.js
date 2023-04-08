/* функция добавления ведущих нулей */
/* (если число меньше десяти, перед числом добавляем ноль) */
function zero_first_format(value)
{
    if (value < 10)
    {
        value='0'+value;
    }
    return value;
}

function random_num(count)
{
    return Math.floor(Math.random() * count)
}

/* функция получения текущей даты и времени */
function date_time()
{
    var current_datetime = new Date("2022", random_num(12), random_num(31));
    var day = zero_first_format(current_datetime.getDate());
    var month = zero_first_format(current_datetime.getMonth()+1); /*функция getMonth() возвращает значение от 0 до 11*/

    return day+"."+month+".2022";
}

/*достаем содержимое файла news.txt,
разбиваем текст на список,
составляем блок таблиц,
выводим содержимое блока на сайт*/     
$.get('news.txt', function(data) {
    
    var news = data.split("+");
    var tr;
    for (let i = 0; i < news.length; i++){  
        tr += '<tr><td>' + date_time() + '</td><td>' + news[i] + '</td></tr>';
    }
    $('#table_2').append(tr);
});