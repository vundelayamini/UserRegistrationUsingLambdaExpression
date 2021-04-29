using System;
using System.Collections.Generic;

namespace UserRegexUsingLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Message to User Regex Using Lambda");
            Pattren pattren = new Pattren();//Create Object 
            Console.WriteLine("Enter Your First Name");//Take input from the user
            string firstName = Console.ReadLine();//Store the input for firstname
            Console.WriteLine(pattren.ValidateFirstName(firstName));
            Console.WriteLine("Enter Your Last Name"); ;//take input from the user
            string lastName = Console.ReadLine(); ;//Store the input for lastname
            Console.WriteLine(pattren.ValidateLastName(lastName));
            Console.WriteLine("Enter Your Email Address"); ;//take input from the user
            string email = Console.ReadLine();//Store the input for email
            Console.WriteLine(pattren.ValidateEmail(email));//Store the input for email
            Console.WriteLine("Enter Your Mobile Number");//take input from the user
            string mobileNum = Console.ReadLine();//Store the input for mobile number
            Console.WriteLine(pattren.ValidateMobile(mobileNum));
            Console.WriteLine("Enter Your Password");//take input from the user
            string password = Console.ReadLine();//Store the input for password
            Console.WriteLine(pattren.ValidatePassword(password));

           
            
        }


    }
}
