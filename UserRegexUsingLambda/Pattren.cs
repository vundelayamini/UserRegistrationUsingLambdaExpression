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
        public const string Regex_Password = "^(?=.*[A-Z])(?=.*\\d)[\\S]{8,}$";

        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, Regex_FirstName))
                return true;
            else
                throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, Regex_LastName))
                return true;
            else
                throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
        }
        public bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, Regex_Email))
                return true;
            else
                throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_EMAIL, "Invalid Email");
        }
        public bool ValidateMobile(string mobileNum)
        {
            if (Regex.IsMatch(mobileNum, Regex_MobileNumber))
                return true;
            else
                throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");
        }
        public bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, Regex_Password))
                return true;
            else
                throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }
    }

}

    

