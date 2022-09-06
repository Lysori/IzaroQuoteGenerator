using DailyIzaroQuote.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DailyIzaroQuote
{
    //writes random random Izaro Quote from txt ressource file to console
    internal class IzaroQuote
    {
        //txt file as resource string in project, attribute of class IzaroQuote
        public string izaro = Resources.IzarosQuotes;

        public string RandomQuote()
        {
            //split resource string each line as element in an array of strings             
            string[] lines = izaro.Split(Environment.NewLine.ToCharArray());
            int lineCount = lines.Length;

            Random random = new Random();
            int lineNum = random.Next(lineCount);

            string result = "Izaro: " + lines[lineNum];

            return result;

        }
    }
}
