namespace railways;

public class Passenger
{
    public string PassengerName { get; set; }
    public int PassengerID { get; set; }
    public int PassengerAge { get; set; }
    public string PassengerGender { get; set; }
    
    public string[] PassengerSpecialty = { "Senior", "PWD", "Differently Abled", "NOT APPLICABLE"};
    
    
    public string PassengerSpecialtyChoosed;
    public void setPassengerDetails()
    {
        
        Random rnd = new Random();
        PassengerID = rnd.Next(40001, 250000);
        
        Console.WriteLine("Enter Passenger Name:  ");
        PassengerName = Console.ReadLine();
        
        Console.WriteLine("Enter Passenger Age: ");
        PassengerAge = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Passenger Gender: ");
        PassengerGender = Console.ReadLine();
        
        Console.WriteLine("Enter Passenger Specialty (press 1-4): ");
        for (int i = 0; i < PassengerSpecialty.Length; i++)
        {
            Console.WriteLine((i + 1) + " " + PassengerSpecialty[i]);
            
        }
        int passengerSpec = Convert.ToInt32(Console.ReadLine())-1;
        PassengerSpecialtyChoosed = PassengerSpecialty[passengerSpec];
        
    }

    public void getPassengerDetails()
    {
        Console.WriteLine("Refer your Passenger Details : ");
        
        Console.WriteLine("PassengerName : " + PassengerName);
        Console.WriteLine("PassengerID : " + PassengerID);
        Console.WriteLine("PassengerAge : " + PassengerAge);
        Console.WriteLine("PassengerGender : " + PassengerGender);
        Console.WriteLine("PassengerSpecialty : " + PassengerSpecialtyChoosed);
        
        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("___________________________________________________________________");
        
    }
}