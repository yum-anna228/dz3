namespace dzz
{
    internal class Program
    {
        enum Dayweek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье

        }

        static void Main(string[] args)
        {
            //Дана последовательность из 10 чисел.Определить, является ли эта последовательность
            //упорядоченной по возрастанию.В случае отрицательного ответа определить
            //порядковый номер первого числа, которое нарушает данную последовательность.
            //Использовать break.
            Console.WriteLine("Задание 1");
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Число {i+1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            bool isOrdered = true;
            for (int i = 0; i < 9; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"Последовательность не упорядочена. Порядковый номер первого числа, которое нарушает данную последовательность: {i+2}");
                    isOrdered = false;
                    break;
                }
            }
            if (isOrdered)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            

            //Игральным картам условно присвоены следующие порядковые номера в зависимости от
            //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
            //«девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
            //соответствующей карты. Использовать try-catch-finally.
            Console.WriteLine("Задание 2");
            try
            {
                Console.Write("Введите порядковый номер карты (6 - 14): ");
                int k = int.Parse(Console.ReadLine());
                if (k < 6 || k > 14)
                {
                    Console.WriteLine("Неверно введён порядковый номер карты.");
                }
                else
                {
                    string cardValue;
                    switch(k)
                    {
                        case 6: cardValue = "Шестёрка"; break;
                        case 7: cardValue = "Семёрка"; break;
                        case 8: cardValue = "Восьмёрка"; break;
                        case 9: cardValue = "Девятка"; break;
                        case 10: cardValue = "Десятка"; break;
                        case 11: cardValue = "Валет"; break;
                        case 12: cardValue = "Дама"; break;
                        case 13: cardValue = "Король"; break;
                        case 14: cardValue = "Туз"; break;
                        default: cardValue = "Неизвестная карта"; break;
                    };

                    Console.WriteLine($"Достоинство карты: {cardValue}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите целое число.");
            }
            finally
            {
                Console.WriteLine("Работа завершена.");
            }

            //Написать программу, которая принимает на входе строку и производит выходные
            //данные в соответствии с таблицей.
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите кем вы являетесь: ");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

                    //Составить программу, которая в зависимости от порядкового номера дня недели(1, 2,
                    //..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
                    //Использовать enum.
                    Console.WriteLine("Задание 4");
            try
            {
                Console.Write("Введите порядковый номер дня недели (1 - 7): ");
                int dayNumber = int.Parse(Console.ReadLine());
                if (dayNumber < 1 || dayNumber > 7)
                {
                    Console.WriteLine("Номер дня недели должен быть в диапазоне от 1 до 7");
                }
                else
                {
                    Dayweek day = (Dayweek)dayNumber;
                    Console.WriteLine($"День недели: {day}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите целое число.");
            }
            finally
            {
                Console.WriteLine("Работа завершена");
            }

            //Создать массив строк.При помощи foreach обойти весь массив.При встрече элемента
            //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            //результату.Вывести на экран сколько кукол в “сумке”.
            Console.WriteLine("Задание 5");
            string[] toys = { "Hello Kitty", "Lego", "Barbie doll", "Ball", "Board game", "Hello Kitty", "Dolls house", "Barbie Doll" };
            int bag = 0;
            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                    bag++;
            }
            Console.WriteLine($"Количество кукол в сумке равно {bag}");


        }
    }
}
