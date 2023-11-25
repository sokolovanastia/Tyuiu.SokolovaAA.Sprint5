using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint5.Task4.V17.Lib;
using System.IO;
namespace Tyuiu.SokolovaAA.Sprint5.Task4.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Соколова А.А. | АСОиУб-23-3";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                         *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                           *");
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #17                                                                       *");
            Console.WriteLine("* Выполнил: Соколова Анастасия Александровна| АСОиУб-23-3                           *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле                       *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V17.txt";

            Console.WriteLine("Данные находится в файле: " + path);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
