using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    public class Pattern 
    {
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$"; //Minimum 3 Characters

        //Method For Validate First Name
        public bool validateFirstName(string fname) 
        {
            return Regex.IsMatch(fname, FIRST_NAME_REGEX);
        }

    }
}

