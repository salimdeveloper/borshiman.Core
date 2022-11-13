using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using EFxceptions;

namespace Borshimar.API.Brokers.Storages
{
    public partial class StorageBroker :EFxceptionsContext, IStorageBroker
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = this.configuration
                .GetConnectionString(name:"DefaultConnection");

            optionsBuilder.UseSqlServer(connectionstring);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
        }
        public override void Dispose() { }
    }
}
