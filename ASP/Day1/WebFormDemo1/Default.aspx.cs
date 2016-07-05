using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    string name = ""; 

    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime myDate = new DateTime();

        myDate = DateTime.Now;

        Label1.Text = "The date and time is: " + DateTime.Now.ToString();


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        name = TextBox1.Text;

        LabelMessage.Text = "Hello, " + TextBox1.Text;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if(CheckBox1.Checked)
        {
            Label3.Text = "The box is checked";
        }
        else
        {
            Label3.Text = "The box is not checked";
        }
    }





    protected void Button3_Click(object sender, EventArgs e)
    {
        if (RadioButton2.Checked)
        {
            Label5.Text = "The Radio button is checked";
        }
        else
        {
            Label5.Text = "The Radio button is not checked";
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if(RadioButtonList1.SelectedItem != null)
        {
            Label7.Text = "you chose " + RadioButtonList1.SelectedItem;
        }
        else
        {
            Label7.Text = "you haven't chosen a button yet ";
        }
        
    }
}