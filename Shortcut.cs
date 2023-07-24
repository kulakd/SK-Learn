using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kobus_Snopbus
{
    public class Shortcut
    {
        [Index(0)]
        public string _short;
        [Index(1)]
        public string _ang;
        [Index(2)]
        public string _pl;

        public Shortcut(string Short, string ang, string pl)
        {
            _short = Short;
            _ang = ang;
            _pl = pl;
        }
    }
}
