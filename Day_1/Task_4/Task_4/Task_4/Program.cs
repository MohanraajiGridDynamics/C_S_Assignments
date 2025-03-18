// See https://aka.ms/new-console-template for more information

using System;

public class City
{
    public string Name { get; set; }
    public int Population { get; set; }
    public int NoOfColleges { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Population: {Population}");
        Console.WriteLine($"No of Colleges: {NoOfColleges}");
    }
}

public class CityDemo
{
    public static void Main()
    {
        City cityObj1 = new City();
        cityObj1.Name = "Chennai";
        cityObj1.Population = 323213;
        cityObj1.NoOfColleges = 233;
        cityObj1.PrintDetails();
        Console.WriteLine();
        
        City cityObj2 = new City();
        cityObj2.Name = "Bangalore";
        cityObj2.Population = 623213;
        cityObj2.NoOfColleges = 293;
        cityObj2.PrintDetails();
        Console.WriteLine();
        
        City cityObj3 = new City();
        cityObj3.Name = "Hyderabad";
        cityObj3.Population = 563213;
        cityObj3.NoOfColleges = 133;
        cityObj3.PrintDetails();
        Console.WriteLine();
        
        City cityObj4 = new City();
        cityObj4.Name = "Tindivanam";
        cityObj4.Population = 3213;
        cityObj4.NoOfColleges = 33;
        cityObj4.PrintDetails();
        Console.WriteLine();
    }
}