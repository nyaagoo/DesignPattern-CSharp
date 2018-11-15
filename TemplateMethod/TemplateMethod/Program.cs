using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetJapan greetJP = new GreetJapan();
            greetJP.Greet();

            GreetEnglish greetENG = new GreetEnglish();
            greetENG.Greet();

            Console.ReadLine();
        }
    }
}
