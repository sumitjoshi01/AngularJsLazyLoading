using AngularJsRoutingPoc.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularJsRoutingPoc.DataAccess.Interfaces
{
    public interface IGroceryRepository
    {
        Task<bool> AddGrocery(GroceryItem groceryItem);

        Task<IEnumerable<GroceryItem>> GetGroceries();
    }
}
