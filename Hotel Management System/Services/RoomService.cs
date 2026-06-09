using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
   public class RoomService
    {

        public static void DisplayAllRooms(List<RoomModel>rooms)
        {
            foreach(var room in rooms)
            {
                Console.WriteLine ($"room number: {room.roomNumber }");
                Console.WriteLine($"room type:  {room.roomType}");
                Console.WriteLine($"room price per night:  {room.pricePerNight}");
                Console.WriteLine($"room isavailable:  {room.isAvailable}");
            }

        }



        public static void DisplayAvailableRooms(List<RoomModel> rooms)
        {
            foreach (var room in rooms)
            {
                if (room.isAvailable)
                {

                    Console.WriteLine($"room number: {room.roomNumber}");
                    Console.WriteLine($"room type:  {room.roomType}");
                    Console.WriteLine($"room price per night:  {room.pricePerNight}");
                    Console.WriteLine($"room isavailable:true");
                }
            }
        }


        public static RoomModel FindRoomByNumber(List<RoomModel>rooms, string roomNumber)
        {
            foreach (var room in rooms)
            {

                if (room.roomNumber == roomNumber)
                {

                    return room;
                }
            
            }
            return null;
        
        }
         
         

     public static double CalculateTotalPrice( RoomModel room,int nights)

        {

            return room.pricePerNight * nights;

        }





    }
}
