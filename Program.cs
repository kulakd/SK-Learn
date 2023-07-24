using Kobus_Snopbus;
using System.Formats.Asn1;
using System.Globalization;
using System;
using CsvHelper.Configuration;
using CsvHelper;


class Program
{
    static void Main(string[] args)
    {
        List<Shortcut> shortcuts = new List<Shortcut>();
        FileSystem file = new FileSystem();
        Game Fight = new Game(shortcuts);
        file.Read(shortcuts);
        Fight.Start();


    }
}