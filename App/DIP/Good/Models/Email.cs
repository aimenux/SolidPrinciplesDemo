using System;

namespace App.DIP.Good.Models
{
    public class Email : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            Console.WriteLine($"Sending {nameof(Email)}");
        }
    }
}