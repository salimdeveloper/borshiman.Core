using Borshiman.Core.Models.Anglers;
using System.Linq;
using System.Threading.Tasks;

namespace Borshiman.Core.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Anglers> InsertAnglerAsync(Anglers anglers);
        IQueryable<Anglers> SelectAllAnglers();
        ValueTask<Anglers> SelectAnglerByIdAsync(long anglerId);
        ValueTask<Anglers> UpdateAnglerAsync(Anglers anglers);
        ValueTask<Anglers> DeleteAnglerAsync(Anglers anglers);
    }
}
