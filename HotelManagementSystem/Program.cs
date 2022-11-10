// See https://aka.ms/new-console-template for more information
//using System.Runtime.CompilerServices;




using HotelManagementSystem;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;

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
    roomNumber = "123",
    floorNumber = 1
}); ; ;

rooms.Add(new Room()
{
    isReserved = false,
    roomType = RoomType.DoubleBed,
    roomNumber = "205",
    floorNumber = 2
}); ;

rooms.Add(new Room()
{
    isReserved = false,
    roomType = RoomType.KingSuite,
    roomNumber = "1729",
    floorNumber = 10

  
}); ;

rooms.Add(new Room()
{
    isReserved = true,
    roomType = RoomType.SingleBed,
    roomNumber = "319",
    floorNumber = 3


}); ;




//Console.ReadLine();

string index = Console.ReadLine();
while (index != "")
{

    // book a reservation
    if (index == "1") 
        
    {
        Console.WriteLine("Enter the room you'd like to book:");
        var vacantRooms = rooms.Where(room => room.isReserved == false).ToList();
        foreach (var room in vacantRooms)
        {
            Console.WriteLine(room.roomNumber);
        }

        string roomNumber = Console.ReadLine();
        
        var roomToBeReserved = vacantRooms.Find(room => room.roomNumber == roomNumber);
        
        Console.WriteLine("Please enter your email for confirmation.");
        string guestEmail = Console.ReadLine();

        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(guestEmail);
        if (match.Success)
        {
            roomToBeReserved.contactEmail = guestEmail;
            Console.WriteLine("Thank you for booking a room! We'll send you a confirmation email at " + guestEmail);
            roomToBeReserved.isReserved = true;
        }
        else
        {
            Console.WriteLine("Please enter valid email: ");
        }
        
        DisplayMenu();


   }

    // add a room
    if (index == "2")
 
    {
        var newRoom = new Room();
        Console.WriteLine("Enter room number:");
        string roomName = Console.ReadLine();
        Console.WriteLine("Enter bed type:");
        var values = Enum.GetValues(typeof(RoomType));
        foreach (var value in values)
        {
            Console.WriteLine(value);
        }
        
        string bedType = Console.ReadLine();
        Enum.TryParse(bedType, out RoomType roomType);
        newRoom.roomType = roomType;
        Console.WriteLine("Enter room floor");
        string roomFloor = Console.ReadLine();
        newRoom.floorNumber = Int32.Parse(roomFloor);
        newRoom.roomNumber = roomName;
        newRoom.isReserved = false;
        rooms.Add(newRoom);
        Console.WriteLine("Thank you for adding a room.");

        DisplayMenu();
    }

    // exit
    if (index == "3")
    {
        
    }

    index = Console.ReadLine(); 

}

void DisplayMenu()
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1) Book reservation");
    Console.WriteLine("2) Add room to system");
    Console.WriteLine("3) Exit");
    Console.Write("\r\nSelect an option: ");

}