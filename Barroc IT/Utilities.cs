using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barroc_IT
{
    static class Utilities
    {
        public static bool checkEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
                return true;    
            else
                return false;

        }

        public static bool checkPhoneNumber(string phoneNumber)
        {
            int number;
            if (!int.TryParse(phoneNumber, out number) && number.ToString().Length == 10)
            {
                return false;
            }
            else
                return true;
        }

        public static bool checkNumber(string number)
        {
            int num;
            if (!int.TryParse(number, out num))
            {
                return false;
            }
            else
                return true;
        }

        public static bool checkZipcode(string zipCode)
        {
            zipCode = zipCode.Replace(" ", "");
            if (zipCode.Length == 6)
            {
                if (Regex.IsMatch(zipCode[0].ToString(), @"^[0-9]+$") && Regex.IsMatch(zipCode[1].ToString(), @"^[0-9]+$") && Regex .IsMatch(zipCode[2].ToString(), @"^[0-9]+$") && Regex .IsMatch(zipCode[3].ToString(), @"^[0-9]+$") && Regex.IsMatch(zipCode[4].ToString(), @"^[a-zA-Z]+$") && Regex.IsMatch(zipCode[5].ToString(), @"^[a-zA-Z]+$"))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }

        public static string GetDate()
        {
            return DateTime.Now.ToShortDateString();
        }
    }
}
