using AngularJsRoutingPoc.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularJsRoutingPoc.Business.Interfaces
{
    public interface IGroceryManager
    {
        Task<bool> AddGrocery(GroceryItem groceryItem);

        Task<IEnumerable<GroceryItem>> GetGroceries();
    }
}
