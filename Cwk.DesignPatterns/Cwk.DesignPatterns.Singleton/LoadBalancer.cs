using System;
using System.Collections.Generic;
using System.Text;

namespace Cwk.DesignPatterns.Singleton
{
    public class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private int _requestCount = 0;

        private LoadBalancer()
        {
            _servers.Add("Server 1");
            _servers.Add("Server 2");
            _servers.Add("Server 3");
            _servers.Add("Server 4");
            _servers.Add("Server 5");
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
                _instance = new LoadBalancer();

            return _instance;
        }

        public void SendRequest(string request)
        {
            var rnd = new Random();
            var r = rnd.Next(_servers.Count);
            Console.WriteLine($"Request {request} sent to {_servers[r]}");
            _requestCount += 1;
        }

        public int GetRequestCount()
        {
            return _requestCount;
        }
    }
}
