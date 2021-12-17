using System;

namespace RegexPatternMatching 
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a Last Name");
            string instr = Console.ReadLine();
            Pattern program = new Pattern();
            //Console.WriteLine(program.validateFirstName(instr));
            Console.WriteLine(program.validateLastName(instr));
        }
    }
}

