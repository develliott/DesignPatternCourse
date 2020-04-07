using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.ChainOfResponsibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Logged");
            return false;
        }
    }
}
