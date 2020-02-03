using System.Collections.Generic;
using App.DIP.Good.Models;

namespace App.DIP.Good.Services
{
    public class SenderService : ISenderService
    {
        private readonly ICollection<IMessage> _messages;

        public SenderService(ICollection<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach(var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}