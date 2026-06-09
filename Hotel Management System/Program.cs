using Hotel_Management_System.Models;
using Hotel_Management_System.Services;

namespace Hotel_Management_System
{
    public class Program
    {
        public static void RegisterGues(HotelContext context)
        {
            Console.WriteLine("Enter guestId");
            string guestId = Console.ReadLine();

            Console.WriteLine("Enter fullName ");
            string fullName = Console.ReadLine();


            Console.WriteLine("Enter Email ");
            string email = Console.ReadLine();


            Console.WriteLine("Enter phoneNumber");
            string phoneNumber = Console.ReadLine();


            context.guests.Add(new GuestModel
            {

                guestId = guestId,

                fullName = fullName,

                email = email,

                phoneNumber = phoneNumber,

                guestBookings = new List<BookingModel>()

            });

            EmailService.SendEmail(
           email,

             "Welcome to Grand Codeline Hotel",
             "Thank you for registering. We look forward to hosting you!"
    );

            Console.WriteLine("Guest registered successfully");
        }


        public static void AddRoom(HotelContext context)
        {

            Console.WriteLine("Enter RoomNumber");
            string roomNumber = Console.ReadLine();

            Console.WriteLine("Enter RoomType ");
            string roomType = Console.ReadLine();


            Console.WriteLine("Enter PricePerNight ");
            double pricePerNight = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter  Floor");
            int floor = Convert.ToInt32(Console.ReadLine());


            RoomModel room = new RoomModel
            {

                roomNumber = roomNumber,

                roomType = roomType,

                pricePerNight = pricePerNight,

                floor = floor,

                isAvailable = true,

            };

            context.rooms.Add(room);

            Console.WriteLine("Room added successfully");



        }


        public static void Main(string[] args)
        {
            HotelContext context = new HotelContext();
            context.bookings = new List<BookingModel>();
            context.guests = new List<GuestModel>();
            context.reviews = new List<ReviewModel>();
            context.rooms = new List<RoomModel>();
            context.staff = new List<StaffModel>();


            bool exit = false;
            while (exit == false)
            {

                Console.WriteLine("Welcome to the hotel system");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1.Add Guest");
                Console.WriteLine("2.Add Room");
                Console.WriteLine("3.Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        RegisterGues(context);
                        break;

                    case 2:
                        AddRoom(context);
                        break;

                    case 3:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }



            }











        }
    }

    }
    

