<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Revenue Distribution</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <center><h1>Calculating Revenue Distribution of Production Share Agreement in Petroleum Industry</h1></center>

    <br/>

    <form id="form1" runat="server">
        
    <div class ="container">
       <div class ="row"> 
            <div class="col-sm-4">
                <asp:Label ID="LabelAnnualProduction" runat="server" Text="Annual Production"></asp:Label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="TextBoxAnnualProduction" runat="server"></asp:TextBox>
            </div>
        </div> 

        <br/>

      <div class ="row">
           <div class="col-sm-4">
        
               <asp:Label ID="LabelOilPrice" runat="server" Text="Oil Price"></asp:Label>
          </div>
          <div class="col-sm-4">
         
              <asp:TextBox ID="TextBoxOilPrice" runat="server"></asp:TextBox>
          </div>
      </div> 
       
        <br/>
    
          <div class ="row">
           <div class="col-sm-4"> 
               <asp:Label ID="LabelRoyalty" runat="server" Text="Royalty"></asp:Label>
           </div>
          <div class="col-sm-4">
         
              <asp:TextBox ID="TextBoxRoyalty" runat="server"></asp:TextBox>
          </div>
      </div>  
        
        <br/>

     <div class ="row">
           <div class="col-sm-4"> 
              <asp:Label ID="LabelOpex" runat="server" Text="OPEX - Operating Cost"></asp:Label>
           </div>
        <div class="col-sm-4">
         
              <asp:TextBox ID="TextBoxOPex" runat="server"></asp:TextBox>
        </div>
     </div>
          
        <br/> 
          

     <div class ="row">
           <div class="col-sm-4">    
               <asp:Label ID="LabelCapex" runat="server" Text="Capex - Capital Cost"></asp:Label>
           </div>
        <div class="col-sm-4">
               <asp:TextBox ID="TextBoxCapex" runat="server"></asp:TextBox>
               
        </div>
     </div>
         
        <br/>
     
     <div class ="row">
           <div class="col-sm-4"> 
               <asp:Label ID="LabelTax" runat="server" Text="Tax"></asp:Label>
           </div>
        <div class="col-sm-4">

               <asp:TextBox ID="TextBoxTax" runat="server"></asp:TextBox>
       </div>
    </div>

        <br/>

        <br/>

     <div class ="row">
           <div class="col-sm-4"> 
              
           </div>
        <div class="col-sm-4">
              <asp:Button ID="Button1" runat="server" Text="Calculate Revenue Distribution" OnClick="Button1_Click"/>
        </div>
    </div>


        <asp:Label ID="LabelTotalAnnualProduction" runat="server" Text=""></asp:Label> 
        <br />
        <asp:Label ID="LabelNetRevenue" runat="server" Text=""></asp:Label>
        <br />
        
        <asp:Label ID="LabelRecoveryCost" runat="server" Text=""></asp:Label>

        <asp:Label ID="LabelEquatyToBeSplitted" runat="server" Text=""></asp:Label>
        
       <%-- <asp:Label ID="LabelOilCompanyTaxableIncome" runat="server" Text=""></asp:Label>
        <asp:Label ID="LabelGovernment" runat="server" Text=""></asp:Label>--%>


   </div> <!--closing container -->



        
        


        
       


        
        


        
       
    </form>
</body>
</html>
