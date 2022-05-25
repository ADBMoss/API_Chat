using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;

namespace APIChat
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new Quotes(client);

            Console.WriteLine($"Conversation Between Kanye West & Ron Swanson:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {quote.KanyeWest()}");
                Console.Write($"Ron Swanson: {quote.RonSwanson()}");

                if (i < 4)
                {
                    Console.WriteLine($"\n------------------------------------");
                    Console.WriteLine("Press Enter to Continue Conversation");
                    Console.WriteLine($"------------------------------------\n");
                    Console.ReadKey();
                    }
                else
                {
                    Console.WriteLine($"\n-------------------");
                    Console.WriteLine("End of Conversation");
                    Console.WriteLine($"-------------------\n");
                    Console.ReadKey();

                }

            }

            


        }
    }
}
