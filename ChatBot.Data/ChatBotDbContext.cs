using ChatBot.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatBot.Data
{
    public class ChatBotDbContext : DbContext
    {
        //public ChatBotDbContext() : base("BotDBConnectionString")
        //{
        //    this.Configuration.LazyLoadingEnabled = false;
        //}
        public ChatBotDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BOT_DOMAIN> BotDomains { set; get; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }
        //public ChatBotDbContext()
        //{
        //    SetContextFactory(() => (DataContext)new CompositionManager().Container.GetExportedValue<IDataContextFactory>().Create());
        //}
    }
}