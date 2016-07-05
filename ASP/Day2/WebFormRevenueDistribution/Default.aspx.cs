using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    decimal LabelProduction = 0;
    decimal AnnualProduction = 0;
    decimal RecoveryCost = 0;
    //decimal labelNetRevenue = 0m;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        AnnualProduction = Convert.ToInt32(TextBoxAnnualProduction.Text);
        
        LabelTotalAnnualProduction.Text = "The Project Gross Revenue is " + (AnnualProduction * Convert.ToInt32(TextBoxOilPrice.Text)).ToString();
        LabelProduction = AnnualProduction * Convert.ToInt32(TextBoxOilPrice.Text);
        LabelNetRevenue.Text = "The Project Net Revenue is " + (LabelProduction * Convert.ToDecimal(TextBoxRoyalty.Text)).ToString();

        RecoveryCost = Convert.ToDecimal(TextBoxOPex.Text);
        LabelRecoveryCost.Text = "The Project Recovery Cost is " + (RecoveryCost + Convert.ToInt32(TextBoxCapex.Text)).ToString();
    }
}

