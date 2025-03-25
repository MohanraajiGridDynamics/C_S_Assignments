namespace railways;

   public class Train
    {
        public int[] Train_ID = {1,2,3,4,5,6,7,8,9,10};
        public string[] Train_Name = {"PExpress","ChennaiExp", "MumbaiExp" , "Vennila", "BangaloreExp", "Yamuna", "Krishna",  "ChennaiLoc", "MumbaiLoc", "Godhavari" };
        //public string Train_Address;
        public string[] Train_Type = { "Express", "Local" };
        public string[] Source = {"Chennai", "Mumbai", "Bangalore", "Hyderabad", "Pune", "Tindivanam", "Guindy", "Tambaram", "WhiteTown", "MumbaiCity"};
        public string[] Destination = {"Chennai", "Mumbai", "Bangalore", "Hyderabad", "Pune", "Tindivanam", "Guindy", "Tambaram", "WhiteTown", "MumbaiCity"};
        public int Available_Coaches;
        //Random random = new Random();
        //random.Next(1, 10);

        private string Train_Choosed { get; set; }
        private string Train_Type_Choosed {get;set;}
        private int Train_ID_Choosed {get;set;}
        private string source_Choosed {get;set;}
        private string destination_Choosed {get;set;}

        public int TicketInfoTrainID;
        public string TicketInfoTrainName;
        public string TicketInfoSource;
        public string TicketInfoDestination;
        public string TicketInfoTrainType;
        
        public void SetTrainDetails()
        {

            Train trainObj = new Train();
            
            Console.WriteLine("Welcome to Mohy Railways");
            
            
            Console.WriteLine("Choose Train types (Press 1 or 2): ");
                for (int i = 0; i < Train_Type.Length; i++)
                {
                    Console.WriteLine((i+1)+" : "+Train_Type[i]);
                }
                int trainType = Convert.ToInt32(Console.ReadLine()) - 1;
                
                try
                {
                    Train_Type_Choosed = Train_Type[trainType];
                    TicketInfoTrainType = Train_Type_Choosed;
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter a valid train type");
                    SetTrainDetails();
                }
               
            
            

            if (trainType == 0)
            {
                Console.WriteLine("Choose from the following trains");
                    for (int i = 0; i < Train_ID.Length-(Train_ID.Length/2); i++)
                    {
                        Console.WriteLine( i + 1 +" "+ Train_Name[i]);
                    }
                    Console.WriteLine("Choose a train (Press 1 - 5): ");
                    int trainNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    Train_Choosed = Train_Name[trainNum];
                    TicketInfoTrainName = Train_Choosed;
                    
                    Train_ID_Choosed = Train_ID[trainNum];
                    TicketInfoTrainID = Train_ID_Choosed;
                    
                
                Console.WriteLine("Choose Source (Press 1 - 5): ");
                    for (int i = 0; i < Source.Length-(Source.Length/2); i++)
                    {
                        Console.WriteLine( i + 1 +" "+ Source[i]);
                    }
                    int sourceNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    source_Choosed = Source[sourceNum];
                    TicketInfoSource = source_Choosed;
                    
                Console.WriteLine("Choose Destination (Press 1 - 5): ");
                    for (int i = 0; i < Destination.Length-(Destination.Length/2); i++)
                    {
                        Console.WriteLine( i + 1 +" "+ Destination[i]);
                    }
                    int destinationNum = Convert.ToInt32(Console.ReadLine()) - 1;
                        
                    destination_Choosed = Destination[destinationNum];
                    TicketInfoDestination = destination_Choosed;
                
            }
            else if(trainType == 1)
            {
                Console.WriteLine("Choose from the following trains");
                for (int i = (Train_ID.Length/2); i < Train_ID.Length; i++)
                {
                    Console.WriteLine( i + 1 +" "+ Train_Name[i]);
                }
                Console.WriteLine("Choose a train (Press 6 - 10): ");
                int trainNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                Train_Choosed = Train_Name[trainNum];
                TicketInfoTrainName = Train_Choosed;
                
                Train_ID_Choosed = Train_ID[trainNum];
                TicketInfoTrainID = Train_ID_Choosed;
                    
                
                Console.WriteLine("Choose Source (Press 6 - 10): ");
                for (int i = (Source.Length/2); i < Source.Length; i++)
                {
                    Console.WriteLine( i + 1 +" "+ Source[i]);
                }
                int sourceNum = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                source_Choosed = Source[sourceNum];
                TicketInfoSource = source_Choosed;
                    
                Console.WriteLine("Choose Destination (Press 6 - 10): ");
                for (int i = (Destination.Length/2); i < Destination.Length; i++)
                {
                    Console.WriteLine( i + 1 +" "+ Destination[i]);
                }
                int destinationNum = Convert.ToInt32(Console.ReadLine()) - 1;
                        
                destination_Choosed = Destination[destinationNum];
                TicketInfoDestination = destination_Choosed;
            }
            else
            {
                Console.WriteLine("Enter a valid train type");
                SetTrainDetails();
            }
            
        }

        public void GetTrainDetails()
        {
            Train trainObj = new Train();
            
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("___________________________________________________________________");
            
            Console.WriteLine("Refer to Train Details");
            
            Console.WriteLine("Your Train is : "+ Train_Choosed);
            Console.WriteLine("Your Train ID is : " + Train_ID_Choosed);
            Console.WriteLine("Your Train Type is : " + Train_Type_Choosed);
            Console.WriteLine("Your Source is : " + source_Choosed);
            Console.WriteLine("Your Destination is : " + destination_Choosed);
            
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("___________________________________________________________________");
        }
        


    }