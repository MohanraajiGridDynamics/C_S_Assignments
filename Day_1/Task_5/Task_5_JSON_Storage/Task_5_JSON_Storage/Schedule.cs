namespace railways;

public class Schedule : Station
{
    public int ScheduleID { get; set; }

    public string[] Timings = {"00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" };
    public string ArrivalTime { get; set; }
    public string DepartureTime { get; set; }
    
    
    public string SourceStation;
    public string DestinationStation;
    
    public string Date { get; set; }


    public void setScheduleInfo()
    {
        Random random = new Random();
        
        Station stationObj = new Schedule();
        
        int arrivalTimeNum = random.Next(1, Timings.Length);
        ArrivalTime = Timings[arrivalTimeNum];
        
        //DepartureTime = random.Next(1, Timings.Length).ToString();

        do
        {
            int departureTimeNum = random.Next(1, Timings.Length);
            DepartureTime = Timings[departureTimeNum];
        } while (DepartureTime == ArrivalTime);
        
        getStationInfo();

        SourceStation = StartStaion;
        DestinationStation = EndStaion;
        
        //SourceStation = stationObj.StartStaion;
        //DestinationStation = stationObj.EndStaion;
        
        Console.WriteLine("Enter Departure Date :");
        Date = Console.ReadLine();
        
        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("___________________________________________________________________");
    }

    public void getScheduleInfo()
    {
        Console.WriteLine("Refer your Train Schedule");
        
        Console.WriteLine("Start Station :"+SourceStation);
        Console.WriteLine("End Station :"+DestinationStation);
        Console.WriteLine("Departure Date :"+Date);
        Console.WriteLine("Arrival Time :"+ArrivalTime);
        Console.WriteLine("Departure Time :"+DepartureTime);
        
        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("___________________________________________________________________");
    }
}
