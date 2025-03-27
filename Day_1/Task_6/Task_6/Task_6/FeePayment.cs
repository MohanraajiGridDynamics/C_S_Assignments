using System.Text.Json;

namespace College;

public class FeePayment
{
    public int ExamFee {get; set;}
    public int LibraryFee {get; set;}
    public int HostelFee {get; set;}
    public int CurriculumFee {get; set;}
    public int MaintenanceFee {get; set;}
    public int OtherFee {get; set;}
    public int MiscellaneousFee {get; set;}
    
    string FeeJsonPath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/FeeData.json";

    public void getFeeDetails()
    {
        string jsonString = File.ReadAllText(FeeJsonPath);
        FeeData fee = JsonSerializer.Deserialize<FeeData>(jsonString);
        
        ExamFee = fee.ExamFee;
        LibraryFee = fee.LibraryFee;
        HostelFee = fee.HostelFee;

        CurriculumFee = 50000;
        MaintenanceFee = 2000;
        OtherFee = 1500;
        MiscellaneousFee = 1000;
        
        Console.WriteLine("The Total Fees per year will be calculated here : ");
        Console.WriteLine($"The Exam Fee will be {ExamFee} per semester ");
        int newExamFee = ExamFee * 2;
        Console.WriteLine($"Considering 2 semesters {ExamFee} * 2 is {newExamFee}");
        
        Console.WriteLine($"The Library Fee will be {LibraryFee} per Year ");
        
        Console.WriteLine($"The Hostel Fee will be {HostelFee} per Month ");
        int newHostelFee = HostelFee * 8;
        Console.WriteLine($"Considering 8 months per year {HostelFee} * 2 is {newHostelFee} per Year ");
        
        Console.WriteLine($"The Curriculum Fee will be {CurriculumFee} per Year ");

        Console.WriteLine($"The Maintenance Fee will be {MaintenanceFee} per Year ");
        Console.WriteLine($"The Other Fee will be {OtherFee} per Year ");
        Console.WriteLine($"The Miscellaneous Fee will be {MiscellaneousFee} per Year ");
        
        int TotalFee = ExamFee + LibraryFee + HostelFee + CurriculumFee + MaintenanceFee + OtherFee + MiscellaneousFee;
        
        Console.WriteLine($"The Total Fees per year is {TotalFee}");
        
    }
}