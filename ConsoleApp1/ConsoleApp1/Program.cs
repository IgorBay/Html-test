using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        string path = @"C:\Users\IgorB\Desktop\Informatic\Html\MyTest.html";

        if (!File.Exists(path))
        {
            string createText = "<big>Red Bull Desert Wings University Challenge<big>" + Environment.NewLine;
            File.WriteAllText(path, createText, Encoding.UTF8);
        }
        string appendText = "<p>В пятницу наша команда Polytech NCM совместно с PRIMO картинг поддержала настоящую мини-гонку на радиоуправляемых, резвых и так похожих на настоящие машинки - Red Bull Desert Wings University Challenge.<p>" + Environment.NewLine;
        string appendText1 = "<p>Мероприятие проводилось на первом этаже главного корпуса Политеха, с музыкой и ведущим, освещавшим самые яркие моменты каждого заезда, а парни и девушки боролись за главный приз - поездку в Перу! Спасибо всем за такой яркий день!" + Environment.NewLine;
        string appendText3 = "<h2>Победителям мужского зачета стали:<h2>" + Environment.NewLine;
        string appendTextone = "<h3>1)Артём Исаев<h3>" + Environment.NewLine;
        string appendText4 = "<h3>2)Михаил Ковалев<h3>" + Environment.NewLine;
        string appendText5 = "<h3>3)Матвей Макаров<h3>" + Environment.NewLine;
        string appendText6 = "<h2>Polytech North Capital Motorsport<h2>" + Environment.NewLine;
        string appendText7 = "<p>Первая инженерно-гоночная команда Северо-Западного федерального округа, выступающая в престижной международной гонке Formula SAE(студенческое соревнование, организованное Сообществом Автомобильных Инженеров SAE). Команда входит в состав Молодежного Конструкторско-Технологического Бюро Политехнического университета имени Петра Великого.<p>" + Environment.NewLine;
        File.AppendAllText(path, appendText);
        File.AppendAllText(path, appendText1);
        File.AppendAllText(path, appendText3);
        File.AppendAllText(path, appendTextone);
        File.AppendAllText(path, appendText4);
        File.AppendAllText(path, appendText5);
        File.AppendAllText(path, appendText6);
        File.AppendAllText(path, appendText7);

        string readText = File.ReadAllText(path);
        string readText1 = File.ReadAllText(path);
        string readText3 = File.ReadAllText(path);
        string readTextone = File.ReadAllText(path);
        string readText4 = File.ReadAllText(path);
        string readText5 = File.ReadAllText(path);
        string readText6 = File.ReadAllText(path);
        string readText7 = File.ReadAllText(path);
        Console.WriteLine(readText);
        Console.WriteLine(readText1);
        Console.WriteLine(readText3);
        Console.WriteLine(readTextone);
        Console.WriteLine(readText4);
        Console.WriteLine(readText5);
        Console.WriteLine(readText6);
        Console.WriteLine(readText7);
    }
}