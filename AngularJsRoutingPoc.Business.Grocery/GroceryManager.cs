using AngularJsRoutingPoc.Business.Interfaces;
using AngularJsRoutingPoc.DataAccess.Interfaces;
using AngularJsRoutingPoc.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularJsRoutingPoc.Business.Grocery
{
    public class GroceryManager : IGroceryManager
    {
        private readonly IGroceryRepository _groceryRepository;

        public GroceryManager(IGroceryRepository groceryRepository)
        {
            _groceryRepository = groceryRepository;
        }

        public async Task<bool> AddGrocery(GroceryItem groceryItem)
        {
            return await _groceryRepository.AddGrocery(groceryItem);
        }

        public async Task<IEnumerable<GroceryItem>> GetGroceries()
        {
            return await _groceryRepository.GetGroceries();
        }
    }
}
