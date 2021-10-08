using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class VendingMachine
    {
        public VendingMachine(Dictionary<string, Snack> inventory)
        {
            Inventory = inventory;
        }

        public Dictionary<string, Snack> Inventory { get; private set; }
        decimal balance = 0;

        public void MainMenu()
        {
            //Output op = new Output();

            Output.Greeting();
            Console.WriteLine();
            Output.DisplayMainMenu();
            string menuInput = Input.GetMenuInput();

            if (menuInput == "1")
            {
                Output.DisplayInventory(Inventory);
            }
            else if (menuInput == "2")
            {
                PurchaseMenu();
            }
            else if (menuInput == "3")
            {
                return;
            }
        }

        public void PurchaseMenu()
        {
            Accounting ac = new Accounting();

            Output.DisplayPurchaseMenu();
            string menuInput = Input.GetMenuInput();

            if (menuInput == "1")
            {
                Output.HowMuchMoney();
                decimal amountFed = Input.GetMoney();

                ac.FeedMoney(balance, amountFed);
                Output.DisplayCurrentMoney(balance);
                PurchaseMenu();
            }
            else if (menuInput == "2")
            {
                SelectSnack();
            }
            else if (menuInput == "3")
            {
                ac.MakeChange(balance);
            }
        }

        public void SelectSnack()
        {
            //Output op = new Output();
            //ExtractInventory ei = new ExtractInventory();
            //Input ip = new Input();

            //Dictionary<string, Snack> inventory = ei.ReadInventoryFile();
            Output.DisplayInventory(Inventory);

            string itemSelected = Input.GetMenuInput();

            if (!Inventory.ContainsKey(itemSelected))
            {
                Console.WriteLine("Item does not exist!");
                Console.ReadLine();
                // TODO: Need to go back to purchase menu
                PurchaseMenu();
            }
            else if (Inventory[itemSelected].Quantity == 0)
            {
                Console.WriteLine("Item is sold out!");
                Console.ReadLine();
                PurchaseMenu();
            }
            else
            {
                Console.WriteLine($"{Inventory[itemSelected].MessageDisplay()}");
            }
        }

    }
}
