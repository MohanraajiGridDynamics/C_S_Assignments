using System.Text.Json;


public class Student
{
    public string jsonFilePath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/StudentData.json";

    public string StudentName;
    public int StudentAge;
    public string StudentGender;
    public string StudentAddress;
    public int YearOfBirth;
    public string StudentEmail;
    public string StudentPhone;
    public string FatherName;
    public string MotherName;
    public void setStudentDetails()
    {
        //StudentData sd = new StudentData();
        
        Console.WriteLine("Enter the Student Details");
        Console.Write("Enter Student Name: ");
        StudentName = Console.ReadLine();
        
        Console.Write("Enter Student Age: ");
        StudentAge = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter Student Gender: ");
        StudentGender = Console.ReadLine();
        
        Console.Write("Enter Student Address: ");
        StudentAddress = Console.ReadLine();
        
        Console.Write("Enter Student Year of Birth: ");
        YearOfBirth = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter Student Email: ");
        StudentEmail = Console.ReadLine();
        
        Console.Write("Enter Student Phone : ");
        StudentPhone = Console.ReadLine();
        
        Console.Write("Enter Father Name: ");
        FatherName = Console.ReadLine();
        
        Console.Write("Enter Mother Name: ");
        MotherName = Console.ReadLine();

        Console.WriteLine("Basic Details Complete : ");
        Console.WriteLine(" Select Course Details ");
        Console.WriteLine(" Redirecting you to Course Page ");

        StudentData studentData = new StudentData()
        {
            StudentName = StudentName,
            StudentAge = StudentAge,
            StudentGender = StudentGender,
            StudentAddress = StudentAddress,
            YearOfBirth = YearOfBirth,
            StudentEmail = StudentEmail,
            StudentPhone = StudentPhone,
            FatherName = FatherName,
            MotherName = MotherName
        };
        string jsonString = JsonSerializer.Serialize(studentData);
        File.WriteAllText(jsonFilePath, jsonString);
        
    }

    public void getStudentDetails()
    {
       // StudentData sd = new StudentData();
        
        string jsonString = File.ReadAllText(jsonFilePath);
        
        StudentData sd = JsonSerializer.Deserialize<StudentData>(jsonString);
        
        Console.WriteLine("Student Name: "+ sd.StudentName);
        ////StudentName = Console.ReadLine();
        
        Console.WriteLine("Student Age: "+ sd.StudentAge);
        //StudentAge = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Student Gender: "+ sd.StudentGender);
        //StudentGender = Console.ReadLine();
        
        Console.WriteLine("Student Address: "+ sd.StudentAddress);
        //StudentAddress = Console.ReadLine();
        
        Console.WriteLine("Student Year of Birth: "+ sd.YearOfBirth);
        //YearOfBirth = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Student Email: "+ sd.StudentEmail);
        //StudentEmail = Console.ReadLine();
        
        Console.WriteLine("Student Phone : "+ sd.StudentPhone);
        //StudentPhone = Console.ReadLine();
        
        Console.WriteLine("Father Name: "+ sd.FatherName);
       // FatherName = Console.ReadLine();
        
        Console.WriteLine("Mother Name: "+ sd.MotherName);
        //MotherName = Console.ReadLine();
    }
}