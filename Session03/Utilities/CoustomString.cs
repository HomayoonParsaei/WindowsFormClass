using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Utilities
{
    public static class CoustomString
    {
        public static string CleanPhoneNumber(this string phoneNumber)
        {
            phoneNumber = phoneNumber.Trim().Replace("+98", "0").Replace("0098", "0");
            phoneNumber = phoneNumber.Length == 10 ? "0" + phoneNumber : phoneNumber;
            return phoneNumber;
        }
        public static string CleanNationalCode(this string nationalCode)
        {
            return nationalCode;
        }
    }
}
