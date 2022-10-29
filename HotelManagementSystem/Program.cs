// See https://aka.ms/new-console-template for more information
//using System.Runtime.CompilerServices;


//Console.Clear();

using HotelManagementSystem;

Console.WriteLine("Choose an option:");
Console.WriteLine("1) Book reservation");
Console.WriteLine("2) Add room to system");
Console.WriteLine("3) Exit");
Console.Write("\r\nSelect an option: ");

var rooms = new List<Room>();
rooms.Add(new Room()
{
    isReserved = false,
    roomType = RoomType.SingleBed,
    roomNumber = "502",
    floorNumber = 5
}); ; ;

rooms.Add(new Room()
{
    isReserved = false,
    roomType = RoomType.SingleBed,
    roomNumber = "503",
    floorNumber = 5
}); ;

rooms.Add(new Room()
{
    isReserved = false,
    roomType = RoomType.SingleBed,
    roomNumber = "504",
    floorNumber = 5
}); ;

Console.WriteLine("Enter 3 to exit");
string line;
while ((line = Console.ReadLine()) != "3")
{
    string result = (line);
    Console.WriteLine(result);

    if (line == "3") 
 {
        
    }

    if (line == "2")
    {
        var newRoom = new Room();
        string roomName = Console.ReadLine();
        newRoom.roomNumber = roomName;
        newRoom.isReserved = false;
        rooms.Add(newRoom);
    }
}