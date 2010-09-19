using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpDDateLib;

namespace SharpDDate
{
    class SharpDDate
    {
        static void Main(string[] args)
        {
            SharpDiscordianDate Date = new SharpDiscordianDate(new DateTime(2009,2,23));

            Console.WriteLine(Date.ToString());
        }
    }
}
