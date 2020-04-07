using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.ChainOfResponsibility
{
    class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HTTPRequest request)
        {
            Console.WriteLine("Compress");
            return false;
        }
    }
}
