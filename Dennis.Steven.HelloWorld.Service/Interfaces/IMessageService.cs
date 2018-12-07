using Dennis.Steven.HelloWorld.Data.Models;
using System.Collections.Generic;

namespace Dennis.Steven.HelloWorld.Service.Interfaces
{
    public interface IMessageService
    {
        IEnumerable<Message> Messages { get; }

        void AddMessage(Message message);
        void AddMessage(IEnumerable<Message> messages);
        void AddMessage(string message);
        void AddMessage(IEnumerable<string> messages);
    }
}
