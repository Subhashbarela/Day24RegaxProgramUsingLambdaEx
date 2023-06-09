﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24LambdaExpression
{
   
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Email Id: ");
            string name = Console.ReadLine();

            Func<string, bool> validate = (email) =>
                Regex.IsMatch(email, "^[A-Za-z0-9]+(.[a-zA-Z0-9]+)?@[a-zA-Z]+.[a-zA-Z]{2,}(.[A-Za-z]{2,})?$");

            if (validate(name))
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id!");
            }
        }



    }
}
