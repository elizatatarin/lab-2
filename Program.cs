using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Лабораторна_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Task 1
            int a = Convert.ToInt32((Console.ReadLine()));
            int b = Convert.ToInt32((Console.ReadLine()));

            int count = 0;
            int sum = 0;
            for (int x = a; x <= b; x++)
                if (x % 3 == 0)
                {
                    count = count + 1;
                }
            Console.WriteLine(count);
            Console.ReadKey();

            //Task 2
            string str = "qwertyuiopasdfghjklzxcvbnm";
            for (int x = 1; x < str.Length; x += 2)
            {
                Console.WriteLine(str[x]);
            }
            Console.ReadKey();*/

            /*//Task 3
            string drink = Console.ReadLine();
            switch (drink)
            {
                case "кава":
                case "Кава":
                    Console.WriteLine("45 гривень");
                    break;
                case "чай":
                case "Чай":
                    Console.WriteLine("25 гривень");
                    break;
                case "нектар":
                case "Нектар":
                    Console.WriteLine("20 гривень");
                    break;
                case "вода":
                case "Вода":
                    Console.WriteLine("18 гривень");
                    break;*/

            /*//Task 4

            int num;
            int sum = 0;
            int count = 0;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                count++;
            }
            while (num > 0);

            double result = (sum - num) / (count - 1);
            Console.WriteLine(result);*/

            /*//Task 5
            int year;
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if ((year % 100 != 0) || ((year % 100 == 0) && (year % 400 == 0)))
                    Console.WriteLine("Вказаний рiк-високосний.");
                else
                    Console.WriteLine("Вказаний рiк-не високосний.");
            }
            else
                Console.WriteLine("Вказаний рiк-не високосний.");*/

            //Task 6
            /*string num = Console.ReadLine();
            int suma = 0;

            foreach (char a in num)
            {
                suma += Convert.ToInt32(a.ToString());
            }
            Console.WriteLine(suma);*/

            /*//Task 7
            string number = Console.ReadLine();
            int cnt = 0;
            foreach (char i in number)
            {
                if (i % 2 != 0)
                    cnt++;
                else
                    break;
            }
            if (cnt == number.Length)
                Console.WriteLine("Всi числа-непарнi.");
            else
                Console.WriteLine("Не всi числа непарнi.");*/

            /*//Task 9
            Console.WriteLine("Введiть номер мiсяця вiд 1 до 12, де 1-сiчень, 2-лютий, 3-березень, 4-квiтень, 5-травень, 6-червень, 7-липень, 8-серпень, 9-вересень, 10-жовтень, 11-листопад, 12-грудень. Якщо хочоте ввести лютий мiсяць у високосному роцi, то введiть '2висок'.");
            string mnth = Console.ReadLine();
            switch(mnth)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    Console.WriteLine("31 день.");
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    Console.WriteLine("30 днів.");
                    break;
                case "2":
                    Console.WriteLine("28 днів.");
                    break;
                case "2висок":
                    Console.WriteLine("29 днів.");
                    break;*/
        }

        }
    }

