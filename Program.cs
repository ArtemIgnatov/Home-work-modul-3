using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_modul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введие Ф.И.О.");
            //Выводим на экран строку с вводом имени
            string FullName = Console.ReadLine();
            //Записываем Ф.И.О. в переменную FullName

            Console.WriteLine("Введие Ваш возраст:");
            //Выводим на экран строку с вводом возраста
            ushort Age =  Convert.ToUInt16(Console.ReadLine());
            //Записываем возраст в переменную Age

            Console.WriteLine("Введие Ваш e-mail:");
            //Выводим на экран строку с вводом почты
            string Mail = Console.ReadLine();
            //Записываем почту в переменную Mail

            Console.WriteLine("Введие Ваши баллы по программированию:");
            //Выводим на экран строку с вводом баллов по програмированию
            double ProgPts = Convert.ToDouble(Console.ReadLine());
            //Записываем баллы по программированию в переменную ProgPts

            Console.WriteLine("Введие Ваши баллы по математике:");
            //Выводим на экран строку с вводом баллов по математике
            double MatPts = Convert.ToDouble(Console.ReadLine());
            //Записываем баллы математике в переменную MatPts

            Console.WriteLine("Введие Ваши баллы по физике:");
            //Выводим на экран строку с вводом баллов по физике
            double PhyPts = Convert.ToDouble(Console.ReadLine());
            //Записываем баллы физике в переменную PhyPts

            Console.WriteLine($"Ф.И.О.: {FullName} \nВозраст: {Age} \ne-mail: {Mail}" +
                $"\nПрограммирование: {ProgPts.ToString("#.##")} \nМатематика: {MatPts.ToString("#.##")} " +
                $"\nФизика: {PhyPts.ToString("#.##")}");
            //Выводим данные 

            Console.ReadKey();
            //Ждем нажатие клавиши, чтобы приступить к выводу среднего балла

            double GPA = (ProgPts + MatPts + PhyPts) / 3;
            //Определяем переменную GPA для подсчета среднего балла

            Console.WriteLine($"Средний балл: {GPA.ToString("#.##")}");
            //Выводим на экран средний балл
            Console.ReadKey();
            //Ждем нажатие клавиши
        }
    }
}
