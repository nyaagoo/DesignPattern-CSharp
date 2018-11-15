using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Abstract;

namespace TemplateMethod
{
    public class GreetEnglish : GreetAbstract
    {
        public GreetEnglish() : base("hi", "Bye From Constructor")
        {

        }
        protected override void Hello()
        {
            Console.WriteLine("Hello");
        }
        protected override void Talk()
        {
            Console.WriteLine("Yeah");
        }

        protected override void Bye()
        {
            Console.WriteLine(_bye);
        }


    }
}
