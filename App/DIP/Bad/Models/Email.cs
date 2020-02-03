using System;

namespace App.DIP.Bad.Models
{
    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            Console.WriteLine($"Sending {nameof(Email)}");
        }
    }
}
