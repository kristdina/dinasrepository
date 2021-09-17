using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 15; // vesels skaitlis
            char myFavoriteLetter = 'D'; // simbols
            bool IsCar = true; // loģiskais true/false
            double myConstant = 4.58; // decimālskaitlis
            float myChangingNum = 2.46f; // mazāks decimālskaitlis (mazāk ciparu aiz komata)
            string name = "Dina"; // teksts


            Console.WriteLine(myNumber);
            Console.WriteLine(myFavoriteLetter);
            Console.WriteLine(IsCar);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangingNum);
            Console.WriteLine(name);

            Console.WriteLine(myConstant + myChangingNum);

            // -----------------------------------------------------------------------------

            int myNumber1 = 4;
            int myNumber2 = 6;

            int sum1 = myNumber1 + myNumber2;

            Console.WriteLine(sum1);

            string name1 = "Hello";
            string name2 = "from code";

            string namesTogether = name1 + " " + name2;

            Console.WriteLine(namesTogether);


            int withPluses = 4;
            withPluses++;

            Console.WriteLine(withPluses);


            int divisionReminder1 = 49;
            int divisionReminder2 = 10;

            int divisionreminderResult = divisionReminder1 % divisionReminder2;

            Console.WriteLine(divisionreminderResult);

            int myNumber5 = 15;
            int myNumber6 = 17;

            bool isEqualNumber = myNumber5 == myNumber6;

            Console.WriteLine(isEqualNumber);

            string myText4 = "ABC";
            string myText5 = "ABC";

            bool isEqualText = myText4 != myText5;

            Console.WriteLine(isEqualText);

            int myNumber7 = 15;
            int myNumber8 = 17;

            bool isEqualNumber2 = myNumber7 > myNumber8;

            Console.WriteLine(isEqualNumber2);



        }
    }
}
