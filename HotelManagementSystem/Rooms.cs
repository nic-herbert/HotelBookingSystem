using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    enum RoomType
    {
        SingleBed,
        DoubleBed,
        QueenSuite,
        KingSuite

    }
    internal class Room
    {
        public RoomType roomType;
        public bool isReserved;
        public string roomNumber;
        public int floorNumber;
        public string contactEmail;

    }

}
