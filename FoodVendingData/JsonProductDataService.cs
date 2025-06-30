using System.Text.Json;
using VendingCommon;

namespace FoodVendingData
{
    public class JsonProductDataService : IFoodVendingDataService
    {
        private static List<VendingItem> snackItems = new();
        private static string jsonFilePath = "inventory.json";

        public JsonProductDataService()
        {
            LoadFromFile();
        }

        public JsonProductDataService(string path)
        {
            jsonFilePath = path;
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            if (File.Exists(jsonFilePath))
            {
                string jsonText = File.ReadAllText(jsonFilePath);
                snackItems = JsonSerializer.Deserialize<List<VendingItem>>(jsonText,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
                ) ?? new List<VendingItem>();
            }
            else
            {
                snackItems = new List<VendingItem>();
                SaveToFile();
            }
        }

        private void SaveToFile()
        {
            string jsonString = JsonSerializer.Serialize(snackItems,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, jsonString);
        }

        private int FindItemIndex(string name)
        {
            return snackItems.FindIndex(item =>
                item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<VendingItem> LoadItems()
        {
            return snackItems.Select(item => new VendingItem
            {
                Name = item.Name,
                Price = item.Price,
                Quantity = item.Quantity
            }).ToList();
        }

        public VendingItem GetItemByName(string name)
        {
            return snackItems.FirstOrDefault(item =>
                item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public bool AddItem(VendingItem item)
        {
            if (FindItemIndex(item.Name) != -1)
                return false;

            snackItems.Add(item);
            SaveToFile();
            return true;
        }

        public bool RemoveItem(string name)
        {
            var index = FindItemIndex(name);
            if (index != -1)
            {
                snackItems.RemoveAt(index);
                SaveToFile();
                return true;
            }
            return false;
        }

        public bool UpdateItemQuantity(string name, int deltaQuantity)
        {
            var index = FindItemIndex(name);
            if (index != -1)
            {
                snackItems[index].Quantity += deltaQuantity;
                SaveToFile();
                return true;
            }
            return false;
        }

        public List<VendingItem> GetAllItems()
        {
            return LoadItems();
        }

        public bool AddNewItem(VendingItem item)
        {
            return AddItem(item);
        }
    }
}
