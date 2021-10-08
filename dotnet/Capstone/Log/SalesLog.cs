using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone
{
    public class SalesLog : LogBase
    {
        private string FileName { get; } = $"Sales_{DateTime.Now:MMddyyyyhhmmsstt}.txt";
        private string Location { get; } = Environment.CurrentDirectory;
        private string  FullPath { get; }

        public SalesLog()
        {
            FullPath = Path.Combine(Location, FileName);
        }

        public override void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(FullPath, true))
            {
                sw.WriteLine(message);
            }
        }
    }
}
