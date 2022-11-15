using Borshiman.Core.Models.Anglers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Borshiman.Core.Brokers.Storages
{
    public partial class StorageBroker 
    {
        public DbSet<Anglers> Anglers { get; set; }
        public async ValueTask<Anglers> InsertAnglerAsync(Anglers anglers)
        {
            using var broker = new StorageBroker(this.configuration);
            
            EntityEntry<Anglers> anglerEntityEntry =
                await broker.Anglers.AddAsync(anglers);

            await broker.SaveChangesAsync();

            return anglerEntityEntry.Entity;
        }
        public IQueryable<Anglers> SelectAllAnglers()
        {
            using var broker =
                new StorageBroker(this.configuration);

            return broker.Anglers;
        }
        public async ValueTask<Anglers> SelectAnglerByIdAsync(long anglerId)
        {
            using var broker =
                new StorageBroker(this.configuration);

            return await broker.Anglers.FindAsync(anglerId);
        }
        public async ValueTask<Anglers> UpdateAnglerAsync(Anglers anglers)
        {
            using var broker =
                new StorageBroker(this.configuration);

            EntityEntry<Anglers> anglerEntityEntry =
                broker.Anglers.Update(anglers);

            await broker.SaveChangesAsync();

            return anglerEntityEntry.Entity;
        }
        public async ValueTask<Anglers> DeleteAnglerAsync(Anglers anglers)
        {
            using var broker =
                new StorageBroker(this.configuration);

            EntityEntry<Anglers> anglerEntityEntry =
                broker.Anglers.Remove(anglers);

            await broker.SaveChangesAsync();

            return anglerEntityEntry.Entity;
        }
    }
}
