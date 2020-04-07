using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HTTPRequest request)
        {
            var isValid = (request.Username == "admin" && request.Password == "1234");

            Console.WriteLine("Authentication");

            return !isValid;
        }
    }
}
