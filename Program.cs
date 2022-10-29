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
        //Task 1
        public static void GetNumberSum(int input)
        {
            
            if (1000 <= input && input <= 9999)
            {
                int firstLevel = input % 10;
                int secondLevel = input / 10 % 10;
                int thirdLevel = input / 100 % 10;
                int fourthLevel = input / 1000;

                int sum = firstLevel + secondLevel + thirdLevel + fourthLevel;
                //Output
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Wrong data");
            }
            
        }
        //Task2
        public static void CheckNumbers(int value)
        {
            int firstLevel = value % 10;
            int secondLevel = value / 10 % 10;
            int thirdLevel = value / 100;

            if (firstLevel == secondLevel && secondLevel == thirdLevel)
            {
                Console.WriteLine("bütün rəqəmlər bərabərdir");
            }
            else
            {
                Console.WriteLine("bütün rəqəmlər bərabər deyil ");
            }
        }
        //Task3
        public static void ChangeLanguage(char inputValue)
        {
            char value = char.ToLower(inputValue);

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
        //Task4
        public static void SearchMonths(string monthName)
        {
            switch (monthName)
            {
                case "January":
                case "March":
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