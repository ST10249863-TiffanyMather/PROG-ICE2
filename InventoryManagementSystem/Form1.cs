using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        private GroceryStore groceryStore;

        public Form1()
        {
            InitializeComponent();
            groceryStore = new GroceryStore();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            List<string> displayMessage = groceryStore.Inventory.DisplayInventory();
            MessageBox.Show(string.Join(Environment.NewLine, displayMessage), "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                //initialise variables
                string name = txtInventory.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                string category = txtCategory.Text;

                //create InventoryItem object
                InventoryItem newItem = new InventoryItem(name, price, quantity, category);

                //add the new item to the inventory
                groceryStore.Inventory.AddItem(newItem);
        
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //get item to remove
            string itemName = txtRemove.Text;
           
            //remove item
            groceryStore.Inventory.RemoveItem(itemName);


        }

    }
}

