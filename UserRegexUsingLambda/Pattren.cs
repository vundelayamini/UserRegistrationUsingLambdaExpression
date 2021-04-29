using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegexUsingLambda
{
    class Pattren
    {
        public const string Regex_FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";// pattren for firstname
        public const string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";//pattren for lastname
        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";//// pattren for  Email
        public const string Regex_MobileNumber = "^[1-9]{1}[0-9]{0,3}\\s[1-9]{1}[0-9]{9}$";// pattren for Mobile number 
        public const string Regex_Password = "^(?=.*[A-Z])(?=.*\\d)[\\S]{8,}$";// pattren for regex password

       //Using Lambda Expressions
        public bool ValidateFirstName(string firstName) => (Regex.IsMatch(firstName, Regex_FirstName));
        public bool ValidateLastName(string lastName) => (Regex.IsMatch(lastName, Regex_LastName));
        public bool ValidateEmail(string email) => (Regex.IsMatch(email, Regex_Email));
        public bool ValidateMobile(string mobNumber) => (Regex.IsMatch(mobNumber, Regex_MobileNumber));
        public bool ValidatePassword(string password) => (Regex.IsMatch(password, Regex_Password));
    }

}

    

