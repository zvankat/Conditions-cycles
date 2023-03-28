using System;

namespace Paractika2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        
        // Задание 1
        Console.WriteLine("Задание 1");
        Console.WriteLine("Введите число: "); 
        int num = int.Parse(Console.ReadLine()); 
        
        if(num > 0) { num += 5; } else { num -= 5; }
        
        Console.WriteLine("Ответ: " + num);
        
        
        
        
        
        // Задание 2
        Console.WriteLine("Задание 2");
        
        Console.WriteLine("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());

        int max = num1;
        if (num2 > max) { max = num2; }
        if (num3 > max) { max = num3; }

        Console.WriteLine("Самое большое число является: " + max);
        
        
        
        
        
        // Задание 3
        Console.WriteLine("Задание 3");
    
        Console.WriteLine("Введите первое число: ");
        int numb1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int numb2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        int numb3 = int.Parse(Console.ReadLine());

        int sum = 0;

        if (numb1 > 0) { sum += numb1; }
        if (numb2 > 0) { sum += numb2; }
        if (numb3 > 0) { sum += numb3; }

        Console.WriteLine("Сумма всех существующих положительных чисел равна: " + sum);
        
        
        
        
        // Задание 4
        Console.WriteLine("Задание 4");
        Console.WriteLine("Введите число x:");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x > 10) { x *= 2; }

        Console.WriteLine("Ответ: " + x);
        
        
        // Задание 5
        Console.WriteLine("Задание 5");
        
        Console.Write("Введите число от 1 до 7 (день недели): ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Это понедельник");
                break;
            case 2:
                Console.WriteLine("Это вторник");
                break;
            case 3:
                Console.WriteLine("Это среда");
                break;
            case 4:
                Console.WriteLine("Это четверг");
                break;
            case 5:
                Console.WriteLine("Это пятница");
                break;
            case 6:
                Console.WriteLine("Это суббота");
                break;
            case 7:
                Console.WriteLine("Это воскресенье");
                break;
            default:
                Console.WriteLine("Ошибка, такого числа нету");
                break;
        }
        
        
        // Задание 6
        Console.WriteLine("Задание 6");

        int chislo = 200;
        while (chislo % 17 != 0 || chislo <= 200)  { chislo++; }
        Console.WriteLine(chislo);
        
        
        // Задание 7
        Console.WriteLine("Задание 7");
        
        double distance = 10;
        int day = 1;

        while (distance < 20)
        {
            distance *= 1.05; // 5%
            day++;
        }
        
        Console.WriteLine("Человек пробежит 20 км за " + day + " дней");

        while (distance < 100)
        {
            distance += 1.05; // 5%
            day++;
        }
        
        Console.WriteLine("Человек пробежит 100 км за " + day + " дней");


        // Задание 8
        Console.WriteLine("Заданме 8");
        Console.WriteLine("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        Console.WriteLine("Факториал числа {0} равен числу {1}", n, fact);


        // Задание 9
        Console.WriteLine("Задание 9");
        Console.WriteLine("Введите натруральное число: ");
        int numberr = int.Parse(Console.ReadLine());
        int delitel = 2;

        while (numberr % delitel != 0 )
        {
            delitel++;
        } 
        
        Console.WriteLine("Наименьший делитель числа {0} равен числу {1}", numberr, delitel);

        }

    }
}