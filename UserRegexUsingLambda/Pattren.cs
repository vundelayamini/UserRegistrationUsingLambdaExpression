using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegexUsingLambda
{
    class Pattren
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";//Create pattren for firstname
        public const string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";//Create pattren for lastname
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";////Create pattren for  Email
        public const string Regex_MobileNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";//Create pattren for Mobile number 
        public const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*\\d)[\\S]{8,}$";
        //  (\S)is use for  matches any non-whitespace character
        public const string Regex_Password = "^(?=.{8,}$)(?=.*[A - Z])(?=.*\\d)(?=.*\\W).*$";// One special character
        public bool ValidateFirstName(string FirstName)//consructor
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }
        public bool ValidateLastName(string LastName)//consructor
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        public bool ValidateEmail(string Email)//Constructor
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
        public bool ValidateMobile(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, Regex_MobileNumber);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }

}

