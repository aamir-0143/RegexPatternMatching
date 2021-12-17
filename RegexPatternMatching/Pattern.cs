﻿using System;
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


        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$"; //Minimum 3 Characters(Khan)

        //Method For Validate Last Name
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, LAST_NAME_REGEX);
        }


        public static string EMAIL_REGEX = "^[a-zA-Z0-9.]+@[a-zA-Z0-9]+.[a-zA-Z0-9]+.[a-zA-Z]{2,4}$"; //eg:-abc.xyz@bl.co.in

        //Method For Validate Email Address
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAIL_REGEX);
        }


        public static string MOBILE_NUMBER_REGEX = "^[0-9]{2}[6-9]{1}[0-9]{9}$"; //Mobile Number With Country Code

        //Method For Validate Mobile Number With Country Code
        public bool validateMobileNumber(string mnumber)
        {
            return Regex.IsMatch(mnumber, MOBILE_NUMBER_REGEX);
        }

        //Method For Paasword Rule-1

        public static string PASSWORD_RULE1_REGEX = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$"; // Minimum 8 characters And All Rules Must Be Passed
        public bool PasswordRule1(string prule1) 
        {
            return Regex.IsMatch(prule1, PASSWORD_RULE1_REGEX);
        }
    }
}

