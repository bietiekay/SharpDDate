using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpDDateLib;

namespace DDate
{
    public partial class DiscordianDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Year = DateTime.Now.Year;
            int Day = DateTime.Now.Day;
            int Month = DateTime.Now.Month;

            string[] mYear = Context.Request.QueryString.GetValues("year");

            if (mYear != null)
            {
                if (mYear[0] != null)
                {
                    Year = Convert.ToInt32(mYear[0]);
                }
            }

            string[] mDay = Context.Request.QueryString.GetValues("day");

            if (mDay != null)
            {
                if (mDay[0] != null)
                {
                    Day = Convert.ToInt32(mDay[0]);
                }
            }

            string[] mMonth = Context.Request.QueryString.GetValues("month");

            if (mMonth != null)
            {
                if (mMonth[0] != null)
                {
                    Month = Convert.ToInt32(mMonth[0]);
                }
            }

            SharpDiscordianDate Date = new SharpDiscordianDate(new DateTime(Year,Month,Day));

            Response.Clear();

            Response.Write(Date.ToString());
        }
    }
}
