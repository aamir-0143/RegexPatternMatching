﻿using System;

namespace RegexPatternMatching 
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            //Console.WriteLine("Enter a Last Name");
            //Console.WriteLine("Enter Email Address: ");
            Console.WriteLine("Enter Mobile Number: ");
            string instr = Console.ReadLine();
            Pattern program = new Pattern();
            //Console.WriteLine(program.validateFirstName(instr));
            //Console.WriteLine(program.validateLastName(instr));
            //Console.WriteLine(program.validateEmail(instr));
            Console.WriteLine(program.validateMobileNumber(instr));

        }
    }
}

