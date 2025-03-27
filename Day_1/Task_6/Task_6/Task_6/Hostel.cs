
using System.Text.Json;

public class Hostel
{
    public int RoomID { get; set; }
    public string RoomType { get; set; }
    public string RoomAdvancements { get; set; }
    public string FoodType { get; set; }
    public string GymType { get; set; }
    public int TotalPrice { get; set; }

    public void SetHostelDetails()
    {
        Console.WriteLine("Hostel Details ");
        Console.WriteLine("Select the type of room you need (press 1 - 4)");
        Console.WriteLine("Single Room (3000)");
        Console.WriteLine("Two-Sharing Room (2500)");
        Console.WriteLine("Three-Sharing Room (2000)");
        Console.WriteLine("Four-Sharing Room (1500)");
        int res = Convert.ToInt32(Console.ReadLine());
        int sharePrice = 0;
        if (res == 1)
        {
            RoomType = "Single Room";
            sharePrice = 3000;
        }
        else if (res == 2)
        {
            RoomType = "Two-Sharing Room";
            sharePrice = 2500;
        }
        else if (res == 3)
        {
            RoomType = "Three-Sharing Room";
            sharePrice = 2000;
        }
        else
        {
            RoomType = "Four-Sharing Room";
            sharePrice = 1500;
        }
        
        Console.WriteLine("Enter the Specifications of your room (Press 1 - 3)");
        Console.WriteLine(" Premium AC (3000) ");
        Console.WriteLine("AC (2000)");
        Console.WriteLine("Non AC (1000)");
        res = Convert.ToInt32(Console.ReadLine());
        int roomFee = 0;
        if (res == 1)
        {
            RoomAdvancements = "Premium AC";
            roomFee = 3000;
        }
        else if (res == 2)
        {
            RoomAdvancements = "AC";
            roomFee = 2000;
        }
        else
        {
            RoomAdvancements = "Non AC";
            roomFee = 1000;
        }
        
        Console.WriteLine("Enter the Food Type (Press 1 - 3)");
        Console.WriteLine(" Non Veg (3000) ");
        Console.WriteLine(" Veg (2000)");
        Console.WriteLine(" Vegan (4500)");
        res = Convert.ToInt32(Console.ReadLine());
        int foodFee = 0;
        if (res == 1)
        {
            FoodType = "Non Veg";
            foodFee = 3000;
        }
        else if (res == 2)
        {
            FoodType = "Veg";
            foodFee = 2000;
        }
        else
        {
            FoodType = "Vegan";
            foodFee = 4500;
        }
        
        Console.WriteLine("Do you want to include Gym (Press 1 - 2)");
        Console.WriteLine(" 1 for GYM (1000)");
        Console.WriteLine(" 2 for NO GYM ");
        res = Convert.ToInt32(Console.ReadLine());

        int gymFee = 0;
        if (res == 1)
        {
            GymType = "Included";
            gymFee = 1000;
        }
        
        TotalPrice = sharePrice + roomFee + foodFee + gymFee;
        
        Random random = new Random();
        RoomID = random.Next(1000, 10000);
    }

    public void GetHostelDetails()
    {

        string jsonFilePath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/HostelData.json";

        HostelData hd = new HostelData
        {
            RoomID = RoomID,
            RoomType = RoomType,
            RoomAdvancements = RoomAdvancements,
            FoodType = FoodType,
            GymType = GymType,
            TotalPrice = TotalPrice,
        };
        string jsonString = JsonSerializer.Serialize(hd);
        File.WriteAllText(jsonFilePath, jsonString);
        
        Console.WriteLine("Hostel Details ");
        Console.WriteLine("Room ID : "+RoomID);
        Console.WriteLine("Room Type : "+RoomType);
        Console.WriteLine("Room Advancements : "+RoomAdvancements);
        Console.WriteLine("Food Type : "+FoodType);
        Console.WriteLine("Gym Type : "+GymType);
        Console.WriteLine("Total Price : "+TotalPrice);
        
        
        string FeeJsonPath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/FeeData.json";

        FeeData fee = new FeeData()
        {
            HostelFee = TotalPrice,
        };
        string feeJsonString = JsonSerializer.Serialize(fee);
        File.WriteAllText(FeeJsonPath, feeJsonString);
        
    }
}