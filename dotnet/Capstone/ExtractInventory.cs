using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class ExtractInventory
    {
        public List<string[]> ReadInventoryFile(string directory, string fileName)
        {
            
            //string directory = Environment.CurrentDirectory;
            //string fileName = "vendingmachine.csv";

            
            string fullPath = Path.Combine(directory, fileName);

            
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
            
        }
    }
}
