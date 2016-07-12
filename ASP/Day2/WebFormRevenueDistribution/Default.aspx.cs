using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int DevidedByTwo = 0;
    decimal EquatyToBeSplitted = 0;
    decimal OilCompanyTaxableIncome = 0;
    decimal LabelProduction = 0;
    decimal AnnualProduction = 0;
    decimal RecoveryCost = 0;
    decimal GovernmentIncome = 0;

   // decimal labelNetRevenue = 0m;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        DropDownList1.Visible = true;
        drawChart(getChartType());
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (DropDownList1.SelectedValue)
        {
            case "pie":
                drawChart("pie");
                break;
            case "doughnut":
                drawChart("doughnut");
                break;
            case "column":
                drawChart("column");
                break;
            case "bar":
                drawChart("bar");
                break;
        }
    }
    public void drawChart(string chartType)
    {
        AnnualProduction = Convert.ToInt32(TextBoxAnnualProduction.Text);

        LabelTotalAnnualProduction.Text = "The Project Gross Revenue is £" + (AnnualProduction * Convert.ToInt32(TextBoxOilPrice.Text)).ToString();
        LabelProduction = AnnualProduction * Convert.ToInt32(TextBoxOilPrice.Text);
        LabelNetRevenue.Text = "The Project Net Revenue is £" + (LabelProduction * Convert.ToDecimal(TextBoxRoyalty.Text)).ToString();

        RecoveryCost = Convert.ToDecimal(TextBoxOPex.Text);
        LabelRecoveryCost.Text = "The Project Recovery Cost is £" + (RecoveryCost + Convert.ToInt32(TextBoxCapex.Text)).ToString();

        EquatyToBeSplitted = LabelProduction * Convert.ToDecimal(TextBoxRoyalty.Text);
        LabelEquatyToBeSplitted.Text = "The Project Equaty to be Splitted between Government and Oil Company is £" + (EquatyToBeSplitted - (RecoveryCost + Convert.ToInt32(TextBoxCapex.Text))).ToString();

        DevidedByTwo = 2;
        OilCompanyTaxableIncome = EquatyToBeSplitted - (RecoveryCost + Convert.ToInt32(TextBoxCapex.Text));
        LabelOilCompanyTaxableIncome.Text = "Oil Comapany Equaty of Equaty to be Splitted is £" + (OilCompanyTaxableIncome / Convert.ToDecimal(DevidedByTwo)).ToString();

        GovernmentIncome = EquatyToBeSplitted - (RecoveryCost + Convert.ToInt32(TextBoxCapex.Text));
        LabelGovernmentIncome.Text = (GovernmentIncome / Convert.ToDecimal(DevidedByTwo)).ToString();

        ClientScript.RegisterStartupScript(GetType(), "draw", "draw('" + chartType + "','" + RecoveryCost + "')", true);
    }

    public string getChartType()
    {
    return DropDownList1.SelectedValue;
    }
}

