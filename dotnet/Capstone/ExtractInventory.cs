using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class ExtractInventory
    {
        public static List<string[]> ReadInventoryFile()
        {
            
            string directory = Environment.CurrentDirectory;
            string filename = "vendingmachine.csv";

            
            string fullPath = Path.Combine(directory, filename);

            
            List<string[]> inventoryItems = new List<string[]>();

            try
            {
                
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    
                    while (!sr.EndOfStream)
                    {
                       
                        string line = sr.ReadLine();

                        
                        string[] items = line.Split('|');
                        inventoryItems.Add(items);
                       
                    } 
                }
            }
            catch (IOException e) 
            {
                
                Console.WriteLine(e.Message);
            }

            return inventoryItems;
            //// Print out each of the words
            //foreach (string inventoryItem in inventoryItems)
            //{
            //    Console.WriteLine(inventoryItem);
            //}
        }
    }
}
