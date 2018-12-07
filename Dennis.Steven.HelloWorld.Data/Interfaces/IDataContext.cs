using Dennis.Steven.HelloWorld.Data.Models;
using System.Collections.Generic;

namespace Dennis.Steven.HelloWorld.Data.Interfaces
{
    public interface IDataContext
    {
        List<Message> Messages { get; set; }
    }
}