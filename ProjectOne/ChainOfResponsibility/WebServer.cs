using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.ChainOfResponsibility
{
    public class WebServer
    {
        private readonly Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HTTPRequest request)
        {
            _handler.Handle(request);
        }
    }
}
