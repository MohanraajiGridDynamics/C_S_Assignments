// See https://aka.ms/new-console-template for more information

using System;

public class Student
{
    private int rollNo;
    private string name;
    private string course;
    private string college;
    
    private int englishGrade;
    private int frenchGrade;
    private int mathsGrade;
    private int scienceGrade;
    private int socialGrade;
    
    public int EnglishGrade{get;set;}
    public int FrenchGrade{get;set;}
    public int MathsGrade{get;set;}
    public int ScienceGrade{get;set;}
    public int SocialGrade{get;set;}
    
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
        
        Console.WriteLine($"English Grade : {EnglishGrade}");
        Console.WriteLine($"French Grade : {FrenchGrade}");
        Console.WriteLine($"Maths Grade : {MathsGrade}");
        Console.WriteLine($"Social Grade : {ScienceGrade}");
        Console.WriteLine($"Social Grade : {SocialGrade}");
        
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
        
        stuObj1.EnglishGrade = 100;
        stuObj1.FrenchGrade = 90;
        stuObj1.MathsGrade = 80;
        stuObj1.ScienceGrade = 70;
        stuObj1.SocialGrade = 60;

        Student stuObj2 = new Student();
        stuObj2.RollNo = 2;
        stuObj2.Name = "Jake";
        stuObj2.Course = "Java";
        stuObj2.College = "NIT";
        
        stuObj2.EnglishGrade = 90;
        stuObj2.FrenchGrade = 90;
        stuObj2.MathsGrade = 90;
        stuObj2.ScienceGrade = 70;
        stuObj2.SocialGrade = 90;

        Student stuObj3 = new Student();
        stuObj3.RollNo = 3;
        stuObj3.Name = "Chris";
        stuObj3.Course = "Python";
        stuObj3.College = "Jeppiyar";
        
        stuObj3.EnglishGrade = 100;
        stuObj3.FrenchGrade = 60;
        stuObj3.MathsGrade = 80;
        stuObj3.ScienceGrade = 90;
        stuObj3.SocialGrade = 10;

        Student stuObj4 = new Student();
        stuObj4.RollNo = 4;
        stuObj4.Name = "Delishia";
        stuObj4.Course = "Django";
        stuObj4.College = "Pachayappas";
        
        stuObj4.EnglishGrade = 0;
        stuObj4.FrenchGrade = 0;
        stuObj4.MathsGrade = 0;
        stuObj4.ScienceGrade = 0;
        stuObj4.SocialGrade = 0;
        
        
        
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