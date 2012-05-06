/*
 * C# Discordian Date Conversion Library
 * 
 * This code was written on the 27th day of Confusion in the Year of Our Lady of Discord 3175 by Daniel Kirstenpfad, http://www.technology-ninja.com 
 * it is based upon DiscDate.c written  the 65th day of The Aftermath in the Year of Our Lady of Discord 3157 
 *      by Druel the Chaotic aka Jeremy Johnson aka mpython@gnu.ai.mit.edu; Worcester MA 01609
 *      
 * You may use it according to the Creative Commons License: BY-NC. 
 * (see attached licensed.txt for full license text)
 * 
 * 
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpDDateLib
{
    public class DiscordianDate
    {
            public int season; /* 0-4 */
            public int day; /* 0-72 */
            public int yday; /* 0-365 */
            public int year; /* 3066- */
		    public bool StTibsDay;
    }

    public class SharpDiscordianDate
    {
        public DiscordianDate hastur;

        #region Private Names
        private String[] Days = new String[5]
        {
            "Sweetmorn",
            "Boomtime",
            "Pungenday",
            "Prickle-Prickle",
            "Setting Orange"
        };

        private String[] Seasons =new String[5]
        {
            "Chaos",
            "Discord",
            "Confusion",
            "Bureaucracy",
            "The Aftermath"
        };

        private String[,] Holidays = new String[5,2]
        {
            { "Mungday", "Chaoflux"},
            {"Mojoday", "Discoflux"},
            {"Syaday", "Confuflux"},
            {"Zaraday", "Bureflux"},
            {"Maladay", "Afflux"}
        };
        #endregion

        #region Helpers
        private String Ending(int Number)
        {
            String Output = "";

            int temp = Number%10;

	    if (Number > 4)
		return "th";

              switch (temp)
              { 
                  case 1:
                  Output = "st";
                  break;
                case 2:
                  Output = "nd";
                  break;
                case 3:
                  Output = "rd";
                  break;
                default:
                  Output = "th";
                  break;
              }
			
            return Output;
        }

        private DiscordianDate Convert(int nday, int nyear)
        {
            DiscordianDate Output = new DiscordianDate();

            Output.year = nyear+3066;
            Output.day = nday;
            Output.season = 0;

            if ((Output.year%4)==2)
            {
                if (Output.day == 59)
                    Output.day=-1;
                else
                    if (Output.day > 59)
                        Output.day-=1;
            }
            Output.yday = Output.day;

            while(Output.day > 73)
            {
                Output.season++;
                Output.day-=73;
            }
            return Output;
        }  


        public DiscordianDate MakeDay(int imonth, int iday, int iyear)
        {
            DiscordianDate Output = new DiscordianDate();

            int[,] cal = new int [2,12]
            {
                {31,28,31,30,31,30,31,31,30,31,30,31},
                { 31,29,31,30,31,30,31,31,30,31,30,31}
            };

            int dayspast = 0;
            imonth--;
            Output.year = iyear+1166;
			
			 if ((imonth == 2) && (iday == 29))
                Output.StTibsDay = true;
            else
                Output.StTibsDay = false;
			
            while(imonth>0)
            {
                dayspast+=cal[(Output.year%4)==2?1:0,--imonth];

            }
            Output.day = dayspast+iday;
            Output.season=0;

            if ((Output.year%4)==2)
            {
                if (Output.day == 59)
                    Output.day=-1;
                else
                    if(Output.day>59)
                        Output.day-=1;
            }

            Output.yday = Output.day;

            while(Output.day>73)
            {
                Output.season++;
                Output.day-=73;
            }

            return Output;
        }

        private String GetDayName(int DayNumber)
        {
            while (DayNumber > 5)
            {
                DayNumber-=5;
            }

            return Days[DayNumber-1];
        }
        #endregion

        #region Constructors
        public SharpDiscordianDate(DateTime NonNormalDateTime)
        {
            hastur = MakeDay(NonNormalDateTime.Month, NonNormalDateTime.Day, NonNormalDateTime.Year);            
        }

        public SharpDiscordianDate()
        {
            hastur = MakeDay(DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Year);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            String Holiday = "";

            if ((hastur.day == 5) || (hastur.day == 50))
            {
                if (hastur.day == 5)
                    Holiday = " Celebrate " + Holidays[hastur.season, 0];
                else
                    Holiday = " Celebrate " + Holidays[hastur.season, 1];
            }
			
            if (hastur.StTibsDay)
                Holiday = " Celebrate St. Tib's Day";


            return "Today is "+GetDayName(hastur.yday) + ", the " + hastur.day + Ending(hastur.day) + " day of " + Seasons[hastur.season] + " in the YOLD " + hastur.year + Holiday + "\n";
        }
        #endregion
    }
}
