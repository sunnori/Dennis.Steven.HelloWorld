using Dennis.Steven.HelloWorld.Data.Interfaces;
using Dennis.Steven.HelloWorld.Service.Interfaces;
using System.ComponentModel.Composition;
using Dennis.Steven.HelloWorld.Data.Models;
using System.Collections.Generic;
using Dennis.Steven.HelloWorld.Service.Extensions;
using System;

namespace Dennis.Steven.HelloWorld.Service
{
    [Export(typeof(IMessageService))]
    public class MessageService : IMessageService
    {
        [ImportingConstructor]
        public MessageService(IDataContext dataContext)
        {
            DataContext = dataContext;
        }

        public IEnumerable<Message> Messages => DataContext.Messages;

        private IDataContext DataContext { get; }

        public void AddMessage(string message)
        {
            AddMessage(new Message {
                MessageText = message,
                MessageDate = DateTime.Now
            });
        }

        public void AddMessage(IEnumerable<string> messages)
        {
            messages.ForEach(AddMessage);
        }

        public void AddMessage(IEnumerable<Message> messages)
        {
            messages.ForEach(AddMessage);
        }

        public void AddMessage(Message message)
        {
            DataContext.Messages.Add(message);
        }
    }
}
