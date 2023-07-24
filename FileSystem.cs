using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kobus_Snopbus
{
    public class FileSystem
    {
        public FileSystem(){}

        public void Read(List<Shortcut> shortcuts)
        {
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ",",
            };
            using (var reader = new StreamReader(@"../Files/skroty.csv"))
            using (var csv = new CsvReader(reader, configuration))
            {
                var records = csv.GetRecords<Shortcut>();
                foreach (var r in records)
                {
                    Shortcut sh = new Shortcut(r._short, r._ang, r._pl);
                    shortcuts.Add(sh);
                }
            }


        }
    }
}
