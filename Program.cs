using System;
using System.Collections.Generic;
using System.IO;
using DataAccess;
using KPMToCSV.Class;
using KPMToCSV.Extensions;

namespace KPMToCSV
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var input = Path.GetFullPath(args[0]);
            var output = Path.GetFullPath(args[1]);
            var list = new List<CSVLine>();

            if (!File.Exists(input)) return;

            using (var reader = File.OpenText(input))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    if (line == null) continue; 
                    if (line.StartsWith(Website.WebsiteName))
                    {
                        list.Add(new Website(line.MatchRemoveAndTrim(Website.WebsiteName), reader));
                    }
                    else if(line.StartsWith(Application.ApplicationName))
                    {
                        list.Add(new Application(line.MatchRemoveAndTrim(Application.ApplicationName), reader));
                    }
                }
                while (line != null);
            }

            if (File.Exists(output))
            {
                File.Delete(output);
            }
            var dt = DataTable.New.FromEnumerable(list);
            using (StreamWriter writer = File.CreateText(output))
            {
                dt.SaveToStream(writer); // write back out as a CSV
            }
        }
    }
}
