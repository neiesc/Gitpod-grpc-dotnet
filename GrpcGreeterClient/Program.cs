using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterServer;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://5001-d605c985-c92a-4cf0-bd3b-607112431b10.ws-us02.gitpod.io:443");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
