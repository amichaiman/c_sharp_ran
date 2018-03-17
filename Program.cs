using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Targil2 t = new Targil2();
            
            /*Console.WriteLine("hey honey, enter string");
            string txt = Console.ReadLine();
            
            Console.WriteLine("hey sweety. which inner string would you like to replace?");
            string subtext = Console.ReadLine();

            Console.WriteLine("you're amazing! now enter the new text");
            string replace = Console.ReadLine();

            Console.WriteLine(t.replace(txt, subtext, replace));
            
            Console.WriteLine("ENter string and I'll reverse it");
            string str = Console.ReadLine();   
            Console.WriteLine(t.reverse(str));*/

            
            Console.WriteLine("enter text mathafacka");
            string text = Console.ReadLine();
          
            
            Console.WriteLine("enter char to remove");
            char ch = Char.Parse(Console.ReadLine());
            
            Console.WriteLine(t.removalItems(text,ch));
        }
    }
}