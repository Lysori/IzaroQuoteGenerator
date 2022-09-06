using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace DailyIzaroQuote
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IzaroQuote izaroquote = new IzaroQuote();
            Console.WriteLine(izaroquote.RandomQuote());

            Console.ReadKey();


        }
    }
}