using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Account_Registration
{
    
    internal class StudentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " "; 
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;


        public static string GetFirstName(string hold)
        {
            return FirstName;
        }

        public static string GetLastName(string hold)
        {
            return LastName;
        }

        public static string GetMiddleName(string hold)
        {
            return MiddleName;
        }

        public static string GetAddress(string hold)
        {
            return Address;
        }

        public static string GetProgram(string hold)
        {
            return Program;
        }

        public static long GetAge(long hold)
        {
            return Age;
        }

        public static long GetContactNo(long hold)
        {
            return ContactNo;
        }

        public static long GetStudentNo(long hold)
        {
            return StudentNo;
        }






    }
}
