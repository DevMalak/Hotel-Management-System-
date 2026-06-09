using Hotel_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Services
{
   public class StaffService
    {
        public static void DisplayAllStaff(List<StaffModel> staff)
        {
            foreach (var staffMember in staff)

            {

                Console.WriteLine($"staffId:{staffMember.staffId}");

                Console.WriteLine($"fullName:{staffMember.fullName}");

                Console.WriteLine($"role:{staffMember.role}");

                Console.WriteLine($"isOnDuty:{staffMember.isOnDuty}");

            } }

        public static StaffModel FindStaffById(List<StaffModel> staff, string staffId)
        {
            foreach (var staffMember in staff)
            {

                if (staffMember.staffId == staffId)
                {

                    return staffMember;
                }

            }

            return null;

        }

           public static void ToggleDutyStatus(StaffModel staff)
        {

            if (staff.isOnDuty)
            {

                staff.isOnDuty = false;


            }

            else
            {

                staff.isOnDuty = true;

            }

            Console.WriteLine($"new status:{staff.isOnDuty}");




        }








        }







    }

