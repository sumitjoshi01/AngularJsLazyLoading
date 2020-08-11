using AngularJsRoutingPoc.Business.Interfaces;
using AngularJsRoutingPoc.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AngularJsRoutingPoc.ApiModules.Grocery
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class GroceryController : ControllerBase
    {
        private readonly IGroceryManager _groceryManager;

        public GroceryController(IGroceryManager groceryManager)
        {
            _groceryManager = groceryManager;
        }

        [HttpPost]
        public async Task<GenericResponse<bool>> AddGrocery([FromBody] GroceryItem groceryItem)
        {
            var isAdded = await _groceryManager.AddGrocery(groceryItem);

            GenericResponse<bool> response = new GenericResponse<bool>
            {
                Data = isAdded,
                Status = HttpStatusCode.OK,
                Message = "Item added successfully."
            };

            return response;
        }

        [HttpGet]
        public async Task<GenericResponse<IEnumerable<GroceryItem>>> GetGroceries()
        {
            var groceryList = await _groceryManager.GetGroceries();

            GenericResponse<IEnumerable<GroceryItem>> response = new GenericResponse<IEnumerable<GroceryItem>>
            {
                Data = groceryList,
                Status = HttpStatusCode.OK,
                Message = "Successfully fetched all grocery items."
            };

            return response;
        }
    }
}
