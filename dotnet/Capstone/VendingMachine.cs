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
        public decimal Balance { get; set; } = 0;

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
                MainMenu();
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
            Output.DisplayCurrentMoney(Balance);
            string menuInput = Input.GetMenuInput();
            

            if (menuInput == "1")
            {
                Output.HowMuchMoney();
                decimal amountFed = Input.GetMoney();

                Balance = ac.FeedMoney(Balance, amountFed);
                LogHelper.Log(LogTypes.Audit, $"{DateTime.Now} FEED MONEY: {amountFed} {Balance}");
                Output.DisplayCurrentMoney(Balance);
                PurchaseMenu();
            }
            else if (menuInput == "2")
            {
                if (Balance <= 0)
                {
                    Console.WriteLine("Please add money before making a purchase");
                    PurchaseMenu();
                }
                else
                {
                    string itemSelected = Input.GetMenuInput();
                    SelectSnack(itemSelected);
                    LogHelper.Log(LogTypes.Audit, $"{DateTime.Now} {Inventory[itemSelected].Name} {itemSelected} {Balance + Inventory[itemSelected].Price} {Balance}");
                    PurchaseMenu();
                }
            }
            else if (menuInput == "3")
            {
                ac.MakeChange(Balance);
                LogHelper.Log(LogTypes.Audit, $"{DateTime.Now} GIVE CHANGE: {Balance} $0.00");
                Balance = 0;
                MainMenu();
            }
        }

        public void SelectSnack(string itemSelected)
        {
            //Output op = new Output();
            //ExtractInventory ei = new ExtractInventory();
            //Input ip = new Input();
            Accounting ac = new Accounting();
            //Dictionary<string, Snack> inventory = ei.ReadInventoryFile();
            Output.DisplayInventory(Inventory);

            //string itemSelected = Input.GetMenuInput();

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
            else if (Inventory[itemSelected].Price > Balance)
            {
                Console.WriteLine("Current balance is too low to make this purchase, please add more money");
                Console.ReadLine();
                PurchaseMenu();
            }

            else
            {
                Balance = ac.PurchaseItem(Balance, Inventory[itemSelected].Price);
                InventoryMethods.AdjustInventory(Inventory, itemSelected);
                Console.WriteLine($"{Inventory[itemSelected].MessageDisplay()}");
            }
        }

    }
}
