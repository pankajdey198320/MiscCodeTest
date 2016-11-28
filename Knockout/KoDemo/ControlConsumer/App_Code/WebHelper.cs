using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlConsumer.App_Code
{
    public class WebHelper
    {
        public static string getHtml()
        {
            System.Net.WebClient cl = new System.Net.WebClient();
            cl.BaseAddress = "http://localhost:50265";
            return cl.DownloadString("/home/textbox");
        }
    }
}