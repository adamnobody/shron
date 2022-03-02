using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bababa
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Семь раз отмерь, один раз - четыре.");
            Console.ReadKey();
            
            Console.WriteLine("Введите своё имя.");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию.");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите свою дату рождения.");
            var birthday = Console.ReadLine();
            Console.WriteLine("Введите свой адрес.");
            string city = Console.ReadLine();
            Console.WriteLine("Введите свою страну.");
            string country = Console.ReadLine();
            Console.WriteLine("Введите свой пол.");
            char gender = (char)Console.Read();
            Console.WriteLine($"Информация о студенте: \nИмя: {name}, Фамилия: {surname}, Дата рождения: {birthday}\nАдрес: {city}, Пол: {gender}, Страна: {country}\nИнформация о курсе:\nНазвание курса: Да, Баллы: 56, Количество занятий в неделю: 16, Преподаватель: Четыре");
            Console.ReadKey();
            
            Console.WriteLine("Введите первое число.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите втрое число.");
            int b = int.Parse(Console.ReadLine());
            double result = ( a + b) / 2;
            Console.WriteLine($"Среднее арифметическое двух чисел равно {result}.");
            Console.ReadKey();
            
            Console.WriteLine("Введите первую сторону треугольника.");
            int a = int.Parse(Console.ReadLine());
            double perimetr = a * 3;
            double ploshad = (a * a * Math.Sqrt(3)) / 4;
            Console.WriteLine($"Периметр треугольника равен {perimetr}\nПлощадь треугольника равна {ploshad}.");
            Console.ReadKey();
            
            Console.WriteLine("Введите три числа.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine()); 
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(a<b && b<c);
            Console.WriteLine($"{a}<{b}<{c} = {a < b && b < c}");
            Console.ReadKey();
            
            Console.WriteLine("Введите chetire числа:");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine((x1 + x2) > (x3 + x4));
            Console.ReadKey();
            
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"Число {a} чётное.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {a} нечётное.");
                Console.ReadKey();
            }
            
            Console.WriteLine("Введите число.");
            int a = Int32.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine($"Число {a} положительное.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {a} отрицательное.");
                Console.ReadKey();
            }
            
            Console.WriteLine("Введите двухзначное число.");
            int a = Int32.Parse(Console.ReadLine());
            double edinici = Math.Abs(a % 10); 
            double desyatki = Math.Abs(a / 10);
            Console.WriteLine($"Первое число: {desyatki}\nВторое число: {edinici}");
            Console.ReadKey();
            
            Console.WriteLine("Введите число");
            int chislo = Int32.Parse(Console.ReadLine());
            double sotnya = Math.Abs(chislo / 100);
            double edinici = Math.Abs(chislo % 10);
            double desyatki = 0.0;
            Console.WriteLine($"Новое число: {sotnya}{desyatki}{edinici}");
            Console.ReadKey();
            
            Console.WriteLine("Введите три целых числа.");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
             if ((a == b) || (a == c) || (b == c))
            {
                Console.WriteLine("True.");
                Console.ReadKey();
            }
             else
            {
                Console.WriteLine("False.");
                Console.ReadKey();
            }
            
            Console.WriteLine("Введите три целых числа.");
            double a = double.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            if ((a + b) > c && (b + c) > a && (c + a) > b)
            {
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Треугольник с данными сторонами существует.\nЕго площадь равна {s}.");
                Console.ReadKey();
                
            }
            else
            {
                Console.WriteLine("Треугольник с данными сторонами не существует.");
            }
            
            Console.WriteLine("Введите число x.");
            int x = Int32.Parse(Console.ReadLine());
            double a = x * 2;
            double b = -3 * x;
            if (x < -2 || x > 2)
            {
                Console.WriteLine($"{a}");
                Console.ReadKey();
            }
            else if (-2 <= x && x <= 2)
            {
                Console.WriteLine($"{b}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("КАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫРКАДЫР");
                Console.ReadKey();
            }
            
            Console.WriteLine("Введите число x.");
            int x = Int32.Parse(Console.ReadLine());
            double f = 0;
            if (x > 0)
            {
                f = 2 * Math.Sin(x);
            }
            else if (x <= 0)
            {
                f = 6 - x; 
            }
            Console.WriteLine($"Число f равно {f}.");
            Console.ReadKey();
            
            Console.WriteLine("Введите размер порции.");
            int x = Int32.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Порция стоит 25 рублей.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Порция стоит 50 рублей.");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Порция стоит 75 рублей.");
                    Console.ReadKey();
                    break;
            }
            
            Console.WriteLine("Введите номер дня недели.");
            int nomer = Int32.Parse(Console.ReadLine());
            switch (nomer)
            {
                case 1:
                    Console.WriteLine("Чувак, понедельник.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Товарищ, вторник.");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Среда! Урааааа!");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Щитверг сегодня. Аве.");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Мужики! Пятница! Урааааа!");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Суббота - выпить охота.");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Воскресенье - капец.");
                    Console.ReadKey();
                    break;
            }
            
            Console.WriteLine("Введите число N.");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Счётчик: {i}");
            }
            Console.ReadKey();
            
            for (int i = -3; i <= 24; i += 3)
            {
                Console.Write($"{i} ");
            }
            
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"{i} ");
            }
            for (int i = 100; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
            
            Console.WriteLine("bababa");
            int p = 0;
            int o = 0;
            for (int i = 1; i <= 10; i++)
            {
                int a = Int32.Parse(Console.ReadLine());
                
                if (a >= 0)
                {
                    p += 1;
                }
                else
                {
                    o += 1;
                }
            }
            Console.WriteLine($"Количество положительных чисел равно {p}");
            Console.WriteLine($"Количество отрицательных чисел равно {o}");
            Console.ReadKey();
            
            Console.WriteLine("bababa");
            int o = 0;
            for (int i = 1; i <= 10; i++)
            {
                int a = Int32.Parse(Console.ReadLine());
                o += a;
            }
            Console.WriteLine($"Сумма введённых чисел равна {o}.");
            Console.ReadKey();
            
            int sum = 0;
            int a = 1;
            for (int i = 2; a <= 20;)
            {
                sum += a;
                a += i;

            }
            Console.WriteLine(sum);
            Console.ReadKey();
            
            double product = 1.0;
            for (int i = 1; i <= 10; i++)
            {
                double a = double.Parse(Console.ReadLine());
                product *= a;
            }
            Console.WriteLine(product);
            
            int o;
            int inn; 
            for (o = 2; o < 100; o++)
            {
                for (inn = 2; inn <= (o / 2); inn++)
                {
                    if ((o % inn) == 0) break;
                }
                if (inn > (o / inn)) 
                {
                    Console.WriteLine($"{o} простое число");
                }
            }
            Console.ReadKey();
            
            double z = 0.0;
            for (int x = 2; x <= 8; x++)
            {
                for (int y = 2; y <= 5; y++)
                {
                    z = Math.Pow(x, y);
                    Console.WriteLine(z);
                }
                
            }
            Console.ReadKey();
            
            double z = 0.0;
            for (int x = 30; x <= 33; x++)
            {
                for (int y = 1; y <= 5; y++)
                {
                    z = x - y;
                    Console.WriteLine(z);
                }

            }
            Console.ReadKey();
            
            Console.WriteLine("Введите число N."); 
            int N = Int32.Parse(Console.ReadLine());
            int counter = 0;
            while (counter < N)
            {
                counter++;
                Console.WriteLine($"Счётчик равен {counter}.");
            }
            // Сложность равна O(N)
            
            int counter = 1;
            do
            {
                Console.WriteLine($"Счётчик равен {counter}.");
                counter++;
            } while (counter <= 5);
            // Сложность равна O(5)
            
            int counter1 = 3;
            int counter2 = 3;
            while (counter1 <= 21)
            {
                Console.WriteLine($"Счётчик равен {counter1}.");
                counter1 += 2;
            }
            Console.WriteLine("ВТОРОЙ ЦИКЛ.");
            do
            {
                Console.WriteLine($"Счётчик равен {counter2}.");
                counter2 += 2;
            } while (counter2 <= 21);
            // Сложность равна O(20)
            
            int counter1 = 15;
            int counter2 = 15;
            while (counter1 >= 0)
            {
                Console.WriteLine($"Счётчик равен {counter1}.");
                counter1 -= 3;
            }
            Console.WriteLine("ВТОРОЙ ЦИКЛ.");
            do
            {
                Console.WriteLine($"Счётчик равен {counter2}.");
                counter2 -= 3;
            } while (counter2 >= 0);
            // Сложность равна O(12)
            
            int counter = 10;
            double product = 1;
            while (counter <= 20)
            {
                product *= counter;
                counter += 2;
            }
            Console.WriteLine(product);
            // Сложность равна O(6)
            
            int counter = 0;
            double summa = 0;
            while (counter < 5)
            {
                double a = double.Parse(Console.ReadLine());
                summa += a;
                counter++;
            }
            Console.WriteLine(summa);
            // Сложность равна O(5)
            
            
            int japan;
            int chetire = 0;
            int japanmax = 0;
            do
            {
                japan = Int32.Parse(Console.ReadLine());
                if (japan > japanmax && japan != 0)
                {
                    japanmax = japan;
                    chetire++;
                }

            } while (japan != 0);
            Console.WriteLine($"Максимальное число - {japanmax}, и его номер - {chetire}.");
            // Сложность равна O(N)
        }
    }
}
