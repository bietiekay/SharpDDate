using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SharpDDateLib;

namespace DDate
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SharpDiscordianDate Date = new SharpDiscordianDate();

            TodayDDate.Text = Date.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate != null)
            {
                Response.Redirect("http://ddate.schrankmonster.de/DiscordianDate.aspx?year=" + Calendar1.SelectedDate.Year + "&month=" + Calendar1.SelectedDate.Month + "&day=" + Calendar1.SelectedDate.Day);
            }
        }
    }
}
