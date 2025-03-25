namespace railways;

public class BookingSystem : Schedule
{
    public int TicketNumber{ get; set; }
    public int TrainID{ get; set; }
    public string Source{ get; set; }
    public string Destination{ get; set; }
    public string Date{ get; set; }
    public int Price{ get; set; }
    public int FinalPrice{ get; set; }
    
    public string[] SeatType = { "Non AC", "Sleeper", "AC", "AC SLeeper", "Premium AC" };

    public int numOfSeats{ get; set; }
    public void setTicketBookingInfo()
    {
        Random random = new Random();
        
      //  Train trainObj = new Train();
      
        Station stationObj = new Station();
        
    

        setScheduleInfo();
        getScheduleInfo();
        
        Coach coachObj = new Coach();
        coachObj.setCoachDetails();
        coachObj.getCoachDetails();
        
        Passenger passengerObj = new Passenger();
        passengerObj.setPassengerDetails();
        passengerObj.getPassengerDetails();
        
        TicketNumber = random.Next(10000, 40000);
        
        /* TrainID = trainObj.TicketInfoTrainID;
        Source = trainObj.TicketInfoSource;
        Destination = trainObj.TicketInfoDestination;*/
        
        Console.WriteLine("Enter the Date you want to travel");
        Date = Console.ReadLine();

        int numOfStation = numOfStations;
        
        Price = 50*numOfStation;
        
        Console.WriteLine("Your Travel fee would be : "+Price);
        Console.WriteLine("Choose the type of Seat you would like to travel (Press 1 - 5)");
        for (int i = 0; i < SeatType.Length; i++)
        {
            Console.WriteLine(SeatType[i]+" - Price of Seat excluding from Travel fee : "+(100*(i+1)));
        }
        int SeatNum = Convert.ToInt32(Console.ReadLine());

        switch (SeatNum)
        {
            case 1:
                FinalPrice = 100 * 1 + (Price);
                break;
            case 2:
                FinalPrice = 100 * 2 + (Price);
                break;
            case 3:
                FinalPrice = 100 * 3 + (Price);
                break;
            case 4:
                FinalPrice = 100 * 4 + (Price);
                break;
            case 5:
                FinalPrice = 100 * 5 + (Price);
                break;
            default:
                Console.WriteLine("Please enter a valid number");
                break;
        }
        
      //  Console.WriteLine("Price : "+Price);
      Console.WriteLine(" Enter the Number of seats you want ");
       numOfSeats = Convert.ToInt32(Console.ReadLine());
       FinalPrice *= numOfSeats;
      Console.WriteLine("Final Price of the Ticket : "+FinalPrice);
      Console.WriteLine("Generating Your Ticket In a Minute ");
      
      Console.WriteLine("___________________________________________________________________");
      Console.WriteLine("___________________________________________________________________");
    }
}