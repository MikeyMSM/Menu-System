using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        bool options = false;
        while (!options)
      {
        
            // input the letter a,b,c,q 
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("a) Energy Calculator");
            Console.WriteLine("b) Product List");
            Console.WriteLine("c) Character Encoder");
            Console.WriteLine("q) End the program");
            
            // creat the var in order to create a switch statement
            char OptionsAnswer = Convert.ToChar(Console.ReadLine());
            
            // to repeat if the letter incorrect or correct 
            switch (OptionsAnswer)
            {
                // choosing a 
                case 'a':
                Console.WriteLine("Energy Calculator");
                break;

                // choosing b
                case 'b':
                Console.WriteLine("Product List");
                break ;
                
                //choosing c 
                case 'c':
                Console.WriteLine("Character Encoder");
                break;

                //choosing q 
                case 'q':
                options = true;
                Console.WriteLine("End the program");
                break;
                
                // choosing other alphabets 
                default: 
                Console.WriteLine("Enter only the values 'a', 'b', 'c', or 'q' ");
                break;
              
            }  
            
        }
    } 
}