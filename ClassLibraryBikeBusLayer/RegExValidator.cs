using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibraryBikeBusLayer
{
    public class RegExValidator
    {

        public static bool IsCorrectSNumber(string value)
        {
            if (Regex.IsMatch(value, @"^[0-9]{12}$")) return true;

            return false;
        }

        public static bool IsCharacter(string value)
        {
            if (Regex.IsMatch(value, @"^[a-zA-Z]+$")) return true;
            
            return false;
        }

        public static bool IsDecimalValue(string value)
        {
            if (Regex.IsMatch(value, @"^\d{1,5}.\d{1,2}?$")) return true;
           
            return false;
        }


        public static bool IsDay(string value)
        {
            if (Regex.IsMatch(value, (@"^(0[1-9])|(1[0-9])|(2[0-9])|(3[0-1])$")))
                return true;
            return false;
        }

        public static bool IsMonth(string value)
        {
            if (Regex.IsMatch(value, (@"^(0[1-9])|(1[0-2])$")))
                return true;
            return false;
        }

        public static bool IsYear(string value)
        {
            if (Regex.IsMatch(value, (@"^(200[0-9])|(201[0-9])|(202[0-9])$")))
                return true;
            return false;
        }

        public static bool IsEmpty(string value)
        {
            if (Regex.IsMatch(value, @"^\s*$")) return false;

            return true;
        }


    }
}
