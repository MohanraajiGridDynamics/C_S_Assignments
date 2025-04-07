// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main()
    {
        Console.WriteLine("Different Math Functions");

       // int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23 };

        //Console.WriteLine("The length of the array : "+arr.Length);
        
        Console.WriteLine("Enter two numbers");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"The maximum number between two numbers is {Math.Max(num1, num2)}");
        
        Console.WriteLine($"The minimum number between two numbers is {Math.Min(num1, num2)}");
        
        Console.WriteLine("Enter a number");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"The square root of {num3} is {Math.Sqrt(num3)}");
        
        Console.WriteLine("Enter a negative number");
        int num4 = Convert.ToInt32(Console.ReadLine()); 
        
        Console.WriteLine($"The absolute value of {num4} is {Math.Abs(num4)}");
        
        Console.WriteLine("Enter a float/double");
        double num5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The rounded double {num5} is {Math.Round(num5)}");


    }
}