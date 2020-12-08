using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTopics.classes
{
    static class MyHelper
    {
        public static string GetSurname(this string name, string surname)
        {
            return $"{name} {surname}";
        }

        public static bool IsActive(this string name)
        {
            if (name == "aijaz")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
