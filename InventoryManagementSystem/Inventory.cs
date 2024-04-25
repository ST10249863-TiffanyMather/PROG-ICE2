using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        private Dictionary<string, List<InventoryItem>> inventory;

        public Inventory()
        {
            inventory = new Dictionary<string, List<InventoryItem>>();
        }

        public void AddItem(InventoryItem item)
        {
            if (!inventory.ContainsKey(item.Category))
            {
                inventory[item.Category] = new List<InventoryItem>();
                MessageBox.Show("Item added.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            inventory[item.Category].Add(item);
        }

        public void RemoveItem(string itemName)
        {
            foreach (var categoryList in inventory.Values)
            {
                var itemToRemove = categoryList.FirstOrDefault(item => item.Name == itemName);
                if (itemToRemove != null)
                {
                    categoryList.Remove(itemToRemove);
                    MessageBox.Show("Item Removed.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Exit the method after removing the item
                }
            }
            MessageBox.Show("Item not found.", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public List<string> DisplayInventory()
        {
            List<string> inventoryInfo = new List<string>();

            foreach (var category in inventory)
            {
                inventoryInfo.Add($"Category: {category.Key}");
                foreach (var item in category.Value)
                {
                    inventoryInfo.Add($"Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}");
                }
                inventoryInfo.Add(""); // Add a blank line between categories
            }

            return inventoryInfo;
        }
    }
}