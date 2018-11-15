using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Abstract;

namespace TemplateMethod
{
    public class GreetJapan : GreetAbstract
    {
        protected override void Hello()
        {
            Console.WriteLine("おはようございます。");
        }
        protected override void Talk()
        {
            Console.WriteLine("今日は良い天気ですね。");
        }

        protected override void Bye()
        {
            Console.WriteLine("さようなら。");
        }


    }
}
