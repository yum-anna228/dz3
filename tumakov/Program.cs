namespace tumakov
{
    internal class Program
    {
        static string MonthName(int month)
        {
            switch (month)
            {
                case 1: return "января";
                case 2: return "февраля";
                case 3: return "марта";
                case 4: return "апреля";
                case 5: return "мая";
                case 6: return "июня";
                case 7: return "июля";
                case 8: return "августа";
                case 9: return "сентября";
                case 10: return "октября";
                case 11: return "ноября";
                case 12: return "декабря";
                default: return "";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.1");
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            if (int.TryParse(Console.ReadLine(), out int dayOfYear))
            {
                int month = 0;
                int day = dayOfYear;
                for (int i = 0; i < daysInMonth.Length; i++)
                {
                    if (day <= daysInMonth[i])
                    {
                        month = i + 1; 
                        break;
                    }
                    else
                    {
                        day -= daysInMonth[i]; 
                    }
                }
                Console.WriteLine($"{dayOfYear} соответствует {day} {MonthName(month)}.");
            }
            

            Console.WriteLine("Задание 4.2");
            int[] daysInMonth2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            if (int.TryParse(Console.ReadLine(), out int dayOfYear2) && dayOfYear2 >= 1 && dayOfYear2 <= 365)
            {
                int month = 0;
                int day = dayOfYear2;
                for (int i = 0; i < daysInMonth2.Length; i++)
                {
                    if (day <= daysInMonth2[i])
                    {
                        month = i + 1; 
                        break;
                    }
                    else
                    {
                        day -= daysInMonth2[i]; 
                    }
                }
                Console.WriteLine($"{dayOfYear2} соответствует {day} {MonthName(month)}.");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректное число от 1 до 365.");
            }

            Console.WriteLine("Задание 4.3");
                Console.Write("Введите год: ");
                if (!int.TryParse(Console.ReadLine(), out int year))
                {
                    throw new ArgumentException("Ошибка: Введите корректный год.");
                }
                bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

                if (isLeapYear)
                {
                    Console.WriteLine($"{year} является високосным годом.");
                }
                else
                {
                    Console.WriteLine($"{year} не является високосным годом.");
                }
                int maxDays = isLeapYear ? 366 : 365;
                Console.Write($"Введите номер дня в году (от 1 до {maxDays}): ");

                if (!int.TryParse(Console.ReadLine(), out int dayOfYear3))
                {
                    throw new ArgumentException("Ошибка: Введите корректное число.");
                }
                if (dayOfYear3 < 1 || dayOfYear3 > maxDays)
                {
                    throw new ArgumentOutOfRangeException(nameof(dayOfYear3), "Ошибка: Введите число от 1 до " + maxDays + ".");
                }
                int[] daysInMonth3 = { 31, isLeapYear ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                int month3 = 0;
                int day3 = dayOfYear3;
                for (int i = 0; i < daysInMonth3.Length; i++)
                {
                    if (day3 <= daysInMonth3[i])
                    {
                        month3 = i + 1; 
                        break;
                    }
                    else
                    {
                        day3 -= daysInMonth3[i]; 
                    }
                }
                Console.WriteLine($"{dayOfYear3} соответствует {day3} {MonthName(month3)} {year} года.");
            


        }
    }
}
