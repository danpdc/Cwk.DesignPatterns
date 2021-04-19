using System;

namespace Cwk.DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3)
                Console.WriteLine("Same instance");
            var balancer = LoadBalancer.GetLoadBalancer();

            for (int i = 1; i < 20; i++)
            {
                balancer.SendRequest($"Request {i}");
            }

            var secondBalancer = LoadBalancer.GetLoadBalancer();

            for (int i = 1; i < 20; i++)
            {
                secondBalancer.SendRequest($"Request {i}");
            }

            Console.WriteLine($"Total requests sent: {balancer.GetRequestCount()}");
            Console.WriteLine($"Total requests sent: {secondBalancer.GetRequestCount()}");
        }
    }
}
