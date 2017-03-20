using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ChatBot.Data;

namespace ChatBot.Infrastructure
{
    public static class DbInitializer
    {
        private static ChatBotDbContext _context;

        public static void Initialize(IServiceProvider serviceProvider, string imagesPath)
        {
            _context = (ChatBotDbContext)serviceProvider.GetService(typeof(ChatBotDbContext));
        }
    }
}