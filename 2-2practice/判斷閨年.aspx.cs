using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2practice
{
    public partial class 判斷閨年 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int N = 300;
            if (N % 400 == 0)
            {
                Response.Write("Y");
            }
            else if (N % 4 == 0 & N % 100 == 0)
            {
                Response.Write("N");
            }
            else if (N % 4 == 0 & N % 100 != 0)
            {
                Response.Write("Y");
            }
            else
            {
                Response.Write("N");
            }
        }
    }
}
