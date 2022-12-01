using System;
using System.Collections.Generic;
using App.DIP.Good.Models;
using App.DIP.Good.Services;
using App.Extensions;

namespace App.DIP.Good
{
    public static class DipGoodExample
    {
        public static void Run()
        {
            ConsoleColor.Red.WriteLine(nameof(DipGoodExample));

            var messages = new List<IChannel>
            {
                new Sms(),
                new Email()
            };

            var sender = new SenderService(messages);
            sender.Send();
        }
    }
}
