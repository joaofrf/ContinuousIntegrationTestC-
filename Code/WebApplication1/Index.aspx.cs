using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtTeste_TextChanged(object sender, EventArgs e)
        {
            if (txtTeste.Text.Contains("+"))
            {
                try
                {
                    decimal num1, num2;
                    decimal.TryParse(txtTeste.Text.Split('+')[0].Trim(), out num1);
                    decimal.TryParse(txtTeste.Text.Split('+')[1].Trim(), out num2);

                    txtResult.InnerText = Helper.Add(num1, num2) + "";

                }
                catch (Exception)
                {

                }
            }
        }
    }
}