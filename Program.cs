using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DefinitonOfParity());

            Console.WriteLine(CalculatingAmountInBlackJack());

            Console.WriteLine(IsPrimeNumber());


            Console.ReadKey();
        }
        public static string DefinitonOfParity()//Определение четности или нечетности числа
        {
            Console.WriteLine("------------- Программа для определения честности или нечетности числа --------------");
            Console.WriteLine("Пожалуйста, введите целое число:");

            int number = Convert.ToInt32(Console.ReadLine());
            return number % 2 == 0 ? "Число четное" : "Число нечетное";
        }

        public static int CalculatingAmountInBlackJack()//Подсчет количества карт в игре BlackJack
        {
            Console.WriteLine("------------ Программа для определения суммы карт в игре BlackJack ------------");
            Console.WriteLine("Пожалуйста, введите сколько карт у вас на руках:");

            byte numberOfCards = Convert.ToByte(Console.ReadLine());
            int amountOfCards = 0;
            for(int i = 0; i < numberOfCards; i++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "6":
                        amountOfCards += 6;
                        break;
                    case "7":
                        amountOfCards += 7;
                        break;
                    case "8":
                        amountOfCards += 8;
                        break;
                    case "9":
                        amountOfCards += 9;
                        break;
                    case "10":
                        amountOfCards += 10;
                        break;
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        amountOfCards += 10;
                        break;
                    default:
                        Console.WriteLine("Нет такой карты, введите пожалуйста все заново!");
                        break;
                } 
            }
            return amountOfCards;
        }

        public static String IsPrimeNumber()
        {
            Console.WriteLine("------------- Программа для определения простого числа -------------");
            Console.WriteLine("Введите число, которое вы хотите проверить:");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if(number == 1)
            {
                return $"{number} - простое число";
            }
            for(int i = 2; i * i <= number; i++)
            {
                if(number % i == 0)
                {
                    return $"{number} - не простое число";
                }
            }
            return $"{number} - простое число";

        }
        
    }
   
}
