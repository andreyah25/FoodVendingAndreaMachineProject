using FoodVendingData;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using VendingCommon;
using VendingDataService;

namespace FoodVendingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendingProductController : ControllerBase
    {
        private static readonly DBFoodVendingDataService dataSource = new DBFoodVendingDataService();

        DBFoodVendingDataService vendingService = new DBFoodVendingDataService();

        [HttpGet]
        public ActionResult<IEnumerable<SnackItem>> GetAllSnacks()
        {
            return Ok(vendingService.GetAllItems());
        }
        [HttpPost]
        public ActionResult<bool> AddSnack([FromBody] SnackItem item)
        {
            bool success = vendingService.AddNewItem(item);
            if (!success) return Conflict("Snack already exists. ");
            return Ok(true);
        }
        [HttpPatch("addstock")]
        public ActionResult<bool> AddStock([FromQuery] string name, [FromQuery] int quantity)
        {
            bool success = vendingService.UpdateItemQuantity(name, quantity);
            if (!success) return NotFound("Item not found.");
            return Ok(true);

        }
        [HttpDelete]
        public ActionResult<bool> RemoveSnack([FromQuery] string name)
        {
            bool success = vendingService.RemoveItem(name);
            if (!success) return NotFound("Snack not found.");
            return Ok(true);
        }

    }
}