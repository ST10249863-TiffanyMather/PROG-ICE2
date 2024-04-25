using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class ErrorHandler
    {
        public void HandleError(Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
