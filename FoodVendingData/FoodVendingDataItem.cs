using VendingCommon;
using VendingDataService;

namespace FoodVendingData;

    public class FoodVendingDataItem
{
    DBFoodVendingDataService dataService;

    public FoodVendingDataItem()
    {

        // dataService = new InMemoryFoodDataService();
        // dataService = new TextFileDataService("inventory.txt");
        // dataService = new JsonProductDataService("inventory.json");
        dataService = new DBFoodVendingDataService();
    }

    public List<VendingItem> GetAllItems()
    {
        return dataService.LoadItems();
    }

    public VendingItem GetItemByName(string name)
    {
        return dataService.GetItemByName(name);
    }

    public bool AddNewItem(VendingItem item)
    {
        return dataService.AddItem(item);
    }

    public bool RemoveItem(string name)
    {
        return dataService.RemoveItem(name);
    }

    public bool UpdateItemQuantity(string name, int deltaQuantity)
    {
        return dataService.UpdateItemQuantity(name, deltaQuantity);
    }
}
