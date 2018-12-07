using System;

namespace Dennis.Steven.HelloWorld.Data.Models
{
    public class Message
    {
        public string MessageText { get; set; }
        public DateTime MessageDate { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", MessageDate, MessageText);
        }
    }
}
