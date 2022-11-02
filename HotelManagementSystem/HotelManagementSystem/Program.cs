// See https://aka.ms/new-console-template for more information
//using System.Runtime.CompilerServices;




using HotelManagementSystem;
using System.Collections.Generic;
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
        roomToBeReserved.isReserved = true;
        Console.WriteLine("Thank you for booking a room!");

        DisplayMenu();






        }

    // add a room
    if (index == "2")

    {
        var newRoom = new Room();
        Console.WriteLine("Enter room number:");
        string roomName = Console.ReadLine();
        newRoom.roomNumber = roomName;
        newRoom.isReserved = false;
        rooms.Add(newRoom);
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