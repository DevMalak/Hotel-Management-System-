using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
    public class BookingService
    {
        public static void DisplayAllBookings(List<BookingModel> bookings)
        {

            foreach (var booking in bookings)
            {

                Console.WriteLine($" BookingID:{booking.bookingId}");
                Console.WriteLine($" GuestID:{booking.guestId}");
                Console.WriteLine($"RoomNumber :{booking.roomNumber}");
                Console.WriteLine($"CheckInDat:{booking.checkInDate}");
                Console.WriteLine($"CheckOutDate :{booking.checkOutDate}");
                Console.WriteLine($"TotalPrice :{booking.totalPrice}");
                Console.WriteLine($"Status :{booking.status}");

            }

        }

        public static BookingModel FindBookingById(List<BookingModel> bookings, string bookingId)
        {

            foreach (var booking in bookings)
            {
                if (booking.bookingId == bookingId)
                {

                    return booking;

                }
            }

            return null;

        }

        public static bool CancelBooking(BookingModel booking)
        {

            if (booking.status == "Cancellad")
            {

                return false;



            }
            booking.status = "Cancelled";
            return true;
        }


        public static bool CompleteBooking(BookingModel booking, RoomModel room)
        {
            if (booking.status != "confirmed")
            {
                return false;
            }

            booking.status = "completed";
            room.isAvailable = true;

            return true;
        }







    }
}