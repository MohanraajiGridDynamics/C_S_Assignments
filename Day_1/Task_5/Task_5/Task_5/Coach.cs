namespace railways;

public class Coach
{
    public int CoachId { get; set; }
    public string CoachName { get; set; }
    public int SeatsAvail { get; set; }
    
    public string[] CoachTypes = {"1ST class AC", "1st Class Non AC","2nd Class AC", "2nd Class Non AC", "3rd Class"};

    public void setCoachDetails()
    {
        Random random = new Random();
        
        CoachId = random.Next(1, 21);
        
        Console.WriteLine("Enter Coach Type (press 1-5) :");

        for (int i = 0; i < CoachTypes.Length; i++)
        {
            Console.WriteLine((i+1)+" : "+CoachTypes[i]);
        }
        
        int coachTypeChoosed = Convert.ToInt32(Console.ReadLine());
        CoachName = CoachTypes[coachTypeChoosed];
        
        SeatsAvail = random.Next(1, 43);
        
    }

    public void getCoachDetails()
    {
        Console.WriteLine("Refer your Coach details :");
        
        Console.WriteLine("CoachName : "+CoachName);
        Console.WriteLine("CoachID : "+CoachId);
        Console.WriteLine("Seats Available : "+SeatsAvail);
        
        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("___________________________________________________________________");
    }
}