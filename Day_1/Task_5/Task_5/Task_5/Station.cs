namespace railways;

public class Station : Train
{
    public string[] Station_Names = { "Chennai Egmo", "Coimbatore Jn", "Madurai Jn", "Trichy Jn", "Salem Jn", "Ernakulam Jn", "Kochi Harbour", "Bengaluru Cantt", "Tirunelveli", "Mysuru Jn", "Kottayam", "Thiruvananthapuram Central", "Tirupur", "Palakkad Jn", "Kannur", "Thanjavur", "Vellore Cantonment", "Karur", "Nagercoil Jn", "Katpadi Jn" };
    public int[] Station_Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

    public int numOfStations;

    public string StartStaion;
    public string EndStaion;

    public void getStationInfo()
    {
        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("___________________________________________________________________");
        
        SetTrainDetails();
        GetTrainDetails();
        
        Random random = new Random();
        int randomStartStation = random.Next(1, 19);
        int randomEndStation = random.Next(1, 19);
        int randomNumOfStations = random.Next(1, 13);
        numOfStations = randomNumOfStations;
        int randomMidStation = 0;
        
        
        Console.WriteLine("Your Journey Consists of these stations :");
        
        
        StartStaion = Station_Names[randomStartStation];
        Console.WriteLine("Start Station " + StartStaion);
       
        
        for (int i = 0; i < randomNumOfStations; i++)
        {
            randomMidStation = random.Next(1, 13);
            if (randomMidStation == randomStartStation || randomMidStation == randomEndStation)
            {
                continue;
            }
            else
            {
                Console.WriteLine("Station ID : " + randomMidStation + " Station  is " + Station_Names[randomMidStation]);
            }
        }
        
        EndStaion = Station_Names[randomEndStation];
        Console.WriteLine("End Station : "+ EndStaion);
        
        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("___________________________________________________________________");

    }
}