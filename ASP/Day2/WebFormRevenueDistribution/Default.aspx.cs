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
    decimal Tax = 0;
    int DevidedByHundred = 0;
    decimal RoyaltyCost = 0;
    decimal GovernmentTake = 0;
    decimal OilCompanyTake = 0;

   


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
        DevidedByHundred = 100;
        DevidedByTwo = 2;

        AnnualProduction = Convert.ToInt32(TextBoxAnnualProduction.Text);

        LabelTotalAnnualProduction.Text = "The Project Gross Revenue is £" + (AnnualProduction * Convert.ToDecimal(TextBoxOilPrice.Text)).ToString();
        LabelProduction = AnnualProduction * Convert.ToDecimal(TextBoxOilPrice.Text);
        LabelNetRevenue.Text = "The Project Net Revenue is £" + ((LabelProduction * Convert.ToDecimal(TextBoxRoyalty.Text)) / DevidedByHundred).ToString();

        RecoveryCost = Convert.ToDecimal(TextBoxOPex.Text);
        LabelRecoveryCost.Text = "The Project Recovery Cost is £" + (RecoveryCost + Convert.ToDecimal(TextBoxCapex.Text)).ToString();

        EquatyToBeSplitted = (LabelProduction * Convert.ToDecimal(TextBoxRoyalty.Text)/DevidedByHundred);
        LabelEquatyToBeSplitted.Text = "The Project Equaty to be Splitted between Government and Oil Company is £" + (EquatyToBeSplitted - (RecoveryCost + Convert.ToDecimal(TextBoxCapex.Text))).ToString();

        //DevidedByTwo = 2;
        OilCompanyTaxableIncome = EquatyToBeSplitted - (RecoveryCost + Convert.ToDecimal(TextBoxCapex.Text));
        LabelOilCompanyTaxableIncome.Text = "Oil Comapany Equaty of Equaty to be Splitted is £" + (OilCompanyTaxableIncome / Convert.ToDecimal(DevidedByTwo)).ToString();

        GovernmentIncome = EquatyToBeSplitted - (RecoveryCost + Convert.ToDecimal(TextBoxCapex.Text));
        LabelGovernmentIncome.Text = "The Government Equaty of Equaty to be Splitted is £" + (GovernmentIncome / Convert.ToDecimal(DevidedByTwo)).ToString();

        //DevidedByHundred = 100;
        Tax = EquatyToBeSplitted - (RecoveryCost + Convert.ToDecimal(TextBoxCapex.Text));
        LabelTaxx.Text = "The Total amount of Tax to be Paid by To Government is £" + ((Tax * Convert.ToDecimal(TextBoxTax.Text))/ DevidedByHundred).ToString();

        RoyaltyCost = EquatyToBeSplitted;
        LabelRoyaltyToBePaid.Text = "The amount of Royalty to be paid to Government is £" + ((RoyaltyCost * Convert.ToDecimal(TextBoxRoyalty.Text))/DevidedByHundred).ToString();

        ClientScript.RegisterStartupScript(GetType(), "draw", "draw('" + chartType + "','" + RecoveryCost + "')", true);

        GovernmentTake = (GovernmentIncome / Convert.ToDecimal(DevidedByTwo));
        LabelGovernmentTake.Text = "The total amount of Government benifits/Government take from the Project is £" + ((GovernmentTake + (((Tax * Convert.ToDecimal(TextBoxTax.Text)) / DevidedByHundred)) + ((RoyaltyCost * Convert.ToDecimal(TextBoxRoyalty.Text)) / DevidedByHundred))).ToString();

        OilCompanyTake = (OilCompanyTaxableIncome / Convert.ToDecimal(DevidedByTwo));
        LabelOilCompanyTake.Text ="The total amount that Oil Company benifits/Oil Company take from the project is £" + (GovernmentTake - ((Tax * Convert.ToDecimal(TextBoxTax.Text)) / DevidedByHundred)).ToString();
    }

    public string getChartType()
    {
    return DropDownList1.SelectedValue;
    }
}

