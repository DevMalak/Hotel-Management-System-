using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
  public class GuestService
    {

public static void DisplayAllGuests(List<GuestModel> guests)
        {


            foreach (var guest in guests)
            {
                Console.WriteLine($"GuestId: {guest.guestId}");
                Console.WriteLine($"FullName: {guest.fullName}");
                Console.WriteLine($"Email: {guest.email}");
                Console.WriteLine($"Phone Number: {guest.phoneNumber}");
            }
        }

        public static GuestModel FindGuestById(List<GuestModel> guests, string guestId)
        {
            foreach (var guest in guests)
            {
                if (guest.guestId == guestId)
                {
                    return guest;
                }
            }

            return null;
        }






    }
}
