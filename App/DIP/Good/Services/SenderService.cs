using System.Collections.Generic;
using App.DIP.Good.Models;

namespace App.DIP.Good.Services
{
    public class SenderService : ISenderService
    {
        private readonly ICollection<IChannel> _channels;

        public SenderService(ICollection<IChannel> channels)
        {
            _channels = channels;
        }

        public void Send()
        {
            foreach (var channel in _channels)
            {
                channel.SendMessage();
            }
        }
    }
}