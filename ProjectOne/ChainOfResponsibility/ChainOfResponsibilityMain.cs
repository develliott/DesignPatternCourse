using System.Runtime.InteropServices.ComTypes;

namespace ProjectOne.ChainOfResponsibility
{
    public class ChainOfResponsibilityMain
    {
        public ChainOfResponsibilityMain()
        {
            // auth -> logger -> compressor

            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);

            var server = new WebServer(authenticator);

            server.Handle(new HTTPRequest("admin", "1234"));
        }
    }
}
