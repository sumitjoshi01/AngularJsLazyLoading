using AngularJsRoutingPoc.DataAccess.Interfaces;
using AngularJsRoutingPoc.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularJsRoutingPoc.DataAccess.Grocery
{
    public class GroceryRepository : IGroceryRepository
    {
        private static readonly List<GroceryItem> groceryItems;

        static GroceryRepository()
        {
            groceryItems = new List<GroceryItem>();
        }

        public async Task<bool> AddGrocery(GroceryItem groceryItem)
        {
            return await Task.Factory.StartNew(() =>
            {
                groceryItems.Add(groceryItem);
                return true;
            });
        }

        public async Task<IEnumerable<GroceryItem>> GetGroceries()
        {
            return await Task.Factory.StartNew(() =>
            {
                return groceryItems;
            });
        }
    }
}
