namespace railways;

public class Payment : BookingSystem
{
    public int FinalAmount { get; set; }
    public int PaymentID { get; set; }

    public void ProcessPayment()
    {
        setTicketBookingInfo();
        
        
        Console.WriteLine("Processing payment");
        Console.WriteLine("Your Ticket Price is : "+FinalPrice);
        Console.WriteLine("Are you sure you want to proceed?");
        Console.WriteLine("1. Yes or 2. No?");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Enter your 6 digit UPI PIN");
            string upiPIN = Console.ReadLine();
            Console.WriteLine("Processing Your payment................");
            Console.WriteLine("Almost there...........................");
            Console.WriteLine("***************************************");
            Console.WriteLine("Payment Successful");
            Console.WriteLine("***************************************");
            Console.WriteLine("Generating your Ticket! ");
            
        }
        else
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Payment Failed");
            Console.WriteLine("***************************************");
            //Console.WriteLine(" Redirecting you to Booking System ");
            //setTicketBookingInfo();
        }
        
       /* Ticket ticket = new Ticket();
        ticket.TicketDetails();*/
       
       Console.WriteLine("___________________________________________________________________");
       Console.WriteLine("___________________________________________________________________");
    }
}