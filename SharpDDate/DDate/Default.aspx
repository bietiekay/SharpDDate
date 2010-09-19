<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DDate._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div align="center">
        <font size="+6">Discordian Date Converter<br />
        </font>
    </div>
    This is webpage that converts Gregorian Dates into Erisian Dates. I realease the code behind all this under the CC-BY-NC license. You can <a href="http://dropbox.schrankmonster.de/dropped/SharpDDateLib.zip">grab the source written in C# here.</a><br />
 
        <br />
        
     Do you want to know <a href="http://en.wikipedia.org/wiki/Discordian_calendar">more</a>?<br />
        <br />
        <div align="center">
            <font size="+4">
                <asp:Label ID="TodayDDate" runat="server" Text=""></asp:Label>
            </font>
        </div>
        
    You can convert any date you like (if it exists):
    <p>
    <div align="center">
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Button ID="Button1" runat="server" Text="Convert to Discordian Date" 
            onclick="Button1_Click" />
    </div>
    </p>
    </div>
    <div align="center">
    <script type="text/javascript"><!--
google_ad_client = "pub-3023731853230658";
/* discordian date block 728x90, Erstellt 22.06.09 */
google_ad_slot = "7004430814";
google_ad_width = 728;
google_ad_height = 90;
//-->
</script>
<script type="text/javascript"
src="http://pagead2.googlesyndication.com/pagead/show_ads.js">
</script>
    </div>
    </form>
</body>
</html>
