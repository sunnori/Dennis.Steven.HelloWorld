using Dennis.Steven.HelloWorld.Data.Models;
using Dennis.Steven.HelloWorld.Service;
using Dennis.Steven.HelloWorld.Service.Extensions;
using System;
using System.Collections.Generic;

namespace Dennis.Steven.HelloWorld
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();

            var serviceFactory = new ServiceFactory();

            Console.WriteLine("Steven Dennis - Hello World - Appliation");
            Console.WriteLine("Copyright Steven Dennis 2018");
            Console.WriteLine();

            var messageService = serviceFactory.MessageService;

            messageService.AddMessage("Hello World");

            WriteLineMessages(messageService.Messages);

            Console.ReadKey(true);
        }

        private static void WriteLineMessages(IEnumerable<Message> messages)
        {
            messages.ForEach(m => Console.WriteLine(m));
        }
    }
}
