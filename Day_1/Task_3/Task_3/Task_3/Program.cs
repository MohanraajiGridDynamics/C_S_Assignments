// See https://aka.ms/new-console-template for more information

using System;

public class Student
{
    private int rollNo;
    private string name;
    private string course;
    private string college;
    
    public int RollNo { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public string College { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Roll No : {RollNo}");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Course : {Course}");
        Console.WriteLine($"College : {College}");
    }
}

public class StudentDemo
{
    public static void Main(string[] args)
    {

        Student stuObj1 = new Student();
        stuObj1.RollNo = 1;
        stuObj1.Name = "Mohan";
        stuObj1.Course = "C#";
        stuObj1.College = "SMVEC";

        Student stuObj2 = new Student();
        stuObj2.RollNo = 2;
        stuObj2.Name = "Jake";
        stuObj2.Course = "Java";
        stuObj2.College = "NIT";

        Student stuObj3 = new Student();
        stuObj3.RollNo = 3;
        stuObj3.Name = "Chris";
        stuObj3.Course = "Python";
        stuObj3.College = "Jeppiyar";

        Student stuObj4 = new Student();
        stuObj4.RollNo = 4;
        stuObj4.Name = "Delishia";
        stuObj4.Course = "Django";
        stuObj4.College = "Pachayappas";
        
        stuObj1.PrintDetails();
        Console.WriteLine();
        
        stuObj2.PrintDetails();
        Console.WriteLine();
        
        stuObj3.PrintDetails();
        Console.WriteLine();
        
        stuObj4.PrintDetails();
        Console.WriteLine();
    }
}