namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the program number \n 1.Flip coin \n 2.Leap year" +
               "\n 3. Find Power Of Two \n 4.Harmonic number \n 5.Factors Program \n 6. Calculate Quotient & Reminder \n 7. Swap two numbers \n 8.calculate odd or even \n 9. calculate vowel or not \n 10. Calculate largest number ");
            int proramCheck = Convert.ToInt32(Console.ReadLine());

            switch (proramCheck)
            {
                case 1:
                    UC1FlipCoin.FlipCoin();
                    break;
                case 2:
                    UC2LeapYear.FindleapYear();
                    break;
                case 3:
                    UC3Power_Of_Two.Powertwo();
                    break;
                case 4:
                    UC4Harmonic_Number.Number();
                    break;
                case 5:
                    UC5Factors.FactorMethod();
                    break;
                case 6:
                    UC6QuoReminder.QuoReminder();
                    break;
                case 7:
                   UC7SwapNumber.SwapNumber();
                    break;
                case 8:
                    UC8EvenOdd.evenOdd();
                    break;
                case 9:
                    UC7SwapNumber.SwapNumber();
                    break;
                case 10:
                    UC10Largest_NUM.findlargestNumber();
                    break;

            }
        }
    }
}