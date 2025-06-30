using System.Collections.Generic;

using VendingCommon;

namespace FoodVendingData
{
    public interface IFoodVendingDataService
    {
        List<VendingItem> LoadItems();
        VendingItem GetItemByName(string name);
        bool AddItem(VendingItem item);
        bool RemoveItem(string name);
        bool UpdateItemQuantity(string name, int deltaQuantity);
        List<VendingItem> GetAllItems();
        bool AddNewItem(VendingItem item);
    }
}