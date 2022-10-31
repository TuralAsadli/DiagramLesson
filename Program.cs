using System.Text;



namespace CodeLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            var sum = Console.ReadLine();
            GetNumberSum(int.Parse(sum));

            //Task2
            var number = Console.ReadLine();
            CheckNumbers(int.Parse(number));

            //Task#
            var languageType = Console.ReadLine();
            ChangeLanguage(Convert.ToChar(languageType));

            //Task4
            var chosenNumber = Console.ReadLine();
            SearchMonths(chosenNumber);


        }

        public static void GetNumberSum(int input)
        {

            if ((1000 <= input & input <= 9999) | (-1000 >= input && -9999 <= input))
            {
                int firstLevel = input % 10;
                int secondLevel = input / 10 % 10;
                int thirdLevel = input / 100 % 10;
                int fourthLevel = input / 1000;

                int sum = firstLevel + secondLevel + thirdLevel + fourthLevel;

                //Change language encoding
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Wrong data");
            }

        }

        public static void CheckNumbers(int value)
        {
            if ((100 <= value & value <= 999) | (-100 >= value && -999 <= value))
            {
                int thirdLevel = value % 10;
                int secondLevel = value / 10 % 10;
                int firstLevel = value / 100;

                //Change language encoding
                Console.OutputEncoding = Encoding.UTF8;

                if (firstLevel == secondLevel && secondLevel == thirdLevel)
                {
                    Console.WriteLine("bütün rəqəmlər bərabərdir");
                }
                else if (firstLevel == secondLevel || secondLevel == thirdLevel || firstLevel == thirdLevel)
                {
                    if (firstLevel == secondLevel)
                    {
                        Console.WriteLine("birinci ve ikinci rəqəmlər bərabərdir");
                    }
                    else if (secondLevel == thirdLevel)
                    {
                        Console.WriteLine("ikinci ve ucuncu rəqəmlər bərabərdir");
                    }
                    else
                    {
                        Console.WriteLine("birinci ve ucuncu reqemler beraberdi");
                    }
                }
                else
                {
                    Console.WriteLine("bütün rəqəmlər bərabər deyil ");
                }
            }

        }

        public static void ChangeLanguage(char inputValue)
        {
            char value = char.ToLower(inputValue);
            //Change language encoding
            Console.OutputEncoding = Encoding.UTF8;

            switch (value)
            {
                case 'a':
                    Console.WriteLine("Azərbaycan dili seçildi");
                    break;
                case 'r':
                    Console.WriteLine("Rus dili seçildi");
                    break;
                default:
                    Console.WriteLine("Yanlış sorğu");
                    break;
            }
        }

        public static void SearchMonths(string monthName)
        {
            //Change language encoding
            Console.OutputEncoding = Encoding.UTF8;

            switch (monthName)
            {
                case "January"or "March":
               
                case "May":
                case "July":
                case "Auqust":
                case "October":
                case "December":
                    Console.WriteLine("31");
                    break;


                case "April":
                case "June":
                case "September":
                case "November":
                    Console.WriteLine("30");
                    break;

                case "Febrary":
                    Console.WriteLine("28");
                    break;

                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}
