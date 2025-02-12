using System.Reflection.Metadata.Ecma335;

namespace Topic_4_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userName, pizzaToppings, productName;
            int age;
            double price, discount, otherDiscount;

            discount = 0.5;

            Console.WriteLine("Enter username");
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your username is: " + userName);
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine();
            Console.WriteLine("What is the Price?");
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("The Price is " + (discount * price).ToString("C"));
            Console.WriteLine();
            //Below this is the lesson assignments before going into the assignment
            Console.WriteLine("Enter your favourite pizza topping:");
            pizzaToppings = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your favourite pizza topping is: " + pizzaToppings);
            Console.WriteLine();
            Console.WriteLine("Enter username again");
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your username is: " + userName);
            Console.WriteLine();
            Console.WriteLine("Enter the name of an item:");
            productName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("The name of the item you entered is:" + productName);    
            Console.ReadLine();
        }
    }
}
