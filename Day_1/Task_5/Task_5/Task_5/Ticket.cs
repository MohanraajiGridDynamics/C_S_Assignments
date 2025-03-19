namespace railways;

public class Ticket : Payment
{

     public void TicketDetails()
     {
          
          Console.WriteLine("___________________________________________________________________");
          Console.WriteLine("___________________________________________________________________");
          
          ProcessPayment();
          
          Console.WriteLine("Ticket Details :");
          Console.WriteLine("Ticket Number : " + TicketNumber);
          Console.WriteLine("Train Name : "+TicketInfoTrainName);
          Console.WriteLine("Train Type : "+ TicketInfoTrainType);
          Console.WriteLine("Source : "+TicketInfoSource);
          Console.WriteLine("Destination : "+TicketInfoDestination);
          
          //Console.WriteLine("Passenger Name : "+PassengerName);
          //Console.WriteLine("Train Id : "+TicketInfoTrainId);
          
          Console.WriteLine("Ticket Price : "+FinalPrice);
          Console.WriteLine("Number of seats "+numOfSeats);
          
          Console.WriteLine("___________________________________________________________________");
          Console.WriteLine("___________________________________________________________________");
     }

}