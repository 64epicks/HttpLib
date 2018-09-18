using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Http;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Server : HttpServer
    {
        public Server(int port)
            : base(port)
        {

        }
        public override void handleGETRequest(HttpProcessor p)
        {
            throw new NotImplementedException();
        }
        public override void handlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            throw new NotImplementedException();
        }
        public override void handleOPTIONSRequest(HttpProcessor p)
        {
            throw new NotImplementedException();
        }
    }
}
