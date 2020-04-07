using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOne.ChainOfResponsibility
{
    public abstract class Handler
    {
        private readonly Handler _next;

        protected Handler(Handler next)
        {
            _next = next;
        }

        public abstract bool DoHandle(HTTPRequest request);

        public void Handle(HTTPRequest request)
        {
            if (DoHandle(request)) return;
            _next?.Handle(request);
        }
    }
}
