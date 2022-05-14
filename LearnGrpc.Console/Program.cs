using Greet;
using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearnGrpc.ConsoleApp
{
    class Program
    {
        async static  Task Main(string[] args)
        {
            await StreamingTest();
            Console.WriteLine("press any key to exit");
            Console.ReadKey();
          
        }

       async static Task StreamingTest()
        {    
  
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
      
             var client = new Greeter.GreeterClient(channel);

             var call = client.SayHellos(new HelloRequest { Name = "Клиент" });

            while (await call.ResponseStream.MoveNext())
            {
                Console.WriteLine("Greeting: " + call.ResponseStream.Current.Message);
                
            }

          
        }
                    

    }
}
