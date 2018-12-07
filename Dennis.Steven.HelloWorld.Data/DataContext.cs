using Dennis.Steven.HelloWorld.Data.Interfaces;
using Dennis.Steven.HelloWorld.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Dennis.Steven.HelloWorld.Data
{
    [Export(typeof(IDataContext))]
    public class DataContext : IDataContext
    {
        public DataContext()
        {
            Messages = new List<Message>();
        }

        public List<Message> Messages { get; set; }
    }
}