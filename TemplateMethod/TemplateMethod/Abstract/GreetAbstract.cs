using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Abstract
{
    public abstract class GreetAbstract
    {
        private readonly string _hello;
        protected readonly string _bye;
        public GreetAbstract(string hello, string bye)
        {
            _hello = hello;
            _bye = bye;
        }
        public GreetAbstract()
        {
            _hello = "Helloooooo";
            _bye = "Good Bye";
        }
        protected abstract void Hello();
        protected abstract void Talk();
        protected abstract void Bye();
        public void Greet()
        {
            Console.WriteLine("------------------");
            Hello();
            Talk();
            Bye();
            Console.WriteLine("------------------");
        }
    }
}
