using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {


    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        double res = web.add(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
        TextBox3.Text = Convert.ToString(res);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        double res = web.sub(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
        TextBox3.Text = Convert.ToString(res);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        double res = web.mul(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
        TextBox3.Text = Convert.ToString(res);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Webservice.WebService1 web = new Webservice.WebService1();
        double res = web.div(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text));
        TextBox3.Text = Convert.ToString(res);
    }
    
}