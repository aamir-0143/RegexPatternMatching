using System;

namespace RegexPatternMatching 
{ 
    class Program
    {
        static void Main(string[] args) 
        { 
            string instr = Console.ReadLine();
            Pattern program = new Pattern();
            Console.WriteLine(program.validateFirstName(instr));
        }
    }
}

