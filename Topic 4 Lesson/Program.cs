using System.Reflection.Metadata.Ecma335;

namespace Topic_4_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userName;
            int age, discount;
            double price;

            discount = 50;


            Console.WriteLine("Enter username");
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your username is: " + userName + " ... Press Enter to Continue.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine();
            Console.WriteLine("What is the Price?");
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("The Price is " + price.ToString("C"));

        }
    }
}
