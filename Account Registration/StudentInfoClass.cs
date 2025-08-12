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


        public static string GetFirstName(string ph)
        {
            return FirstName;
        }

        public static string GetLastName(string ph)
        {
            return LastName;
        }

        public static string GetMiddleName(string ph)
        {
            return MiddleName;
        }

        public static string GetAddress(string ph)
        {
            return Address;
        }

        public static string GetProgram(string ph)
        {
            return Program;
        }

        public static long GetAge(long ph)
        {
            return Age;
        }

        public static long GetContactNo(long ph)
        {
            return ContactNo;
        }

        public static long GetStudentNo(long ph)
        {
            return StudentNo;
        }






    }
}
