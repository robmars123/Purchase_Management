<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Assets.aspx.cs" Inherits="Assets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 100%;
            height: 218px;
        }
        .auto-style3 {
            width: 115px
        }
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            width: 115px;
            height: 147px;
        }
        .auto-style6 {
            height: 147px;
        }
        .auto-style7 {
            color: #FFFFFF;
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <strong><span class="auto-style4">Assets</span></strong><br />
    <table class="auto-style2">
        <tr>
            <td class="auto-style5">Asset ID:
                <br />
                <br />
                Employee:<br />
                </td>
            <td class="auto-style6">
                <br />
                <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" Enabled="False" OnTextChanged="TextBox2_TextChanged1" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server" Height="39px" Width="138px" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="EmployeeID1" DataValueField="AssetID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Employees.EmployeeID, Employees.FirstName + ' ' + Employees.LastName AS EmployeeID, Assets.AssetID FROM Employees INNER JOIN Assets ON Employees.EmployeeID = Assets.EmployeeID WHERE (Employees.FirstName + ' ' + Employees.LastName IS NOT NULL) ORDER BY Employees.FirstName"></asp:SqlDataSource>
                
                <br />
                <br />
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>  
               <div id="datalist">
                   <div id="datalist_header" ">
                       Device Info</div>
                   <div id="detailsViewBox">
                   <asp:DetailsView ID="DetailsView1" EmptyDataText="No records or item has been removed. Please choose an employee." runat="server" DataSourceID="SqlDataSource4" margin-left="20px" Height="70px" Width="500px" AutoGenerateRows="False" DataKeyNames="AssetID" Font-Bold="False" GridLines="None">
                       
                       <CommandRowStyle  CssClass="buttonStyle"/>
                       <FieldHeaderStyle BorderWidth="0px" Font-Bold="True" />
                       <Fields>
                           <asp:BoundField DataField="AssetID" HeaderText="AssetID" InsertVisible="False" ReadOnly="True" SortExpression="AssetID" />
                           <asp:BoundField DataField="AssetDescription" HeaderText="AssetDescription" SortExpression="AssetDescription" />
                           <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" SortExpression="EmployeeID" />
                           <asp:BoundField DataField="AssetCategoryID" HeaderText="AssetCategoryID" SortExpression="AssetCategoryID" />
                           <asp:BoundField DataField="StatusID" HeaderText="StatusID" SortExpression="StatusID" />
                           <asp:BoundField DataField="DepartmentID" HeaderText="DepartmentID" SortExpression="DepartmentID" />
                           <asp:BoundField DataField="VendorID" HeaderText="VendorID" SortExpression="VendorID" />
                           <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
                           <asp:BoundField DataField="ModelNumber" HeaderText="ModelNumber" SortExpression="ModelNumber" />
                           <asp:BoundField DataField="SerialNumber" HeaderText="SerialNumber" SortExpression="SerialNumber" />
                           <asp:BoundField DataField="DateAcquired" HeaderText="DateAcquired" SortExpression="DateAcquired" />
                           <asp:BoundField DataField="DateSold" HeaderText="DateSold" SortExpression="DateSold" />
                           <asp:BoundField DataField="PurchasePrice" HeaderText="PurchasePrice" SortExpression="PurchasePrice" />
                           <asp:BoundField DataField="DepreciationMethod" HeaderText="DepreciationMethod" SortExpression="DepreciationMethod" />
                           <asp:BoundField DataField="DepreciableLife" HeaderText="DepreciableLife" SortExpression="DepreciableLife" />
                           <asp:BoundField DataField="SalvageValue" HeaderText="SalvageValue" SortExpression="SalvageValue" />
                           <asp:BoundField DataField="CurrentValue" HeaderText="CurrentValue" SortExpression="CurrentValue" />
                           <asp:BoundField DataField="Comments" HeaderText="Comments" SortExpression="Comments" />
                           <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                           <asp:BoundField DataField="NextSchedMaint" HeaderText="NextSchedMaint" SortExpression="NextSchedMaint" />
                           <asp:BoundField DataField="Processor" HeaderText="Processor" SortExpression="Processor" />
                           <asp:BoundField DataField="RAM" HeaderText="RAM" SortExpression="RAM" />
                           <asp:BoundField DataField="Condition" HeaderText="Condition" SortExpression="Condition" />
                           <asp:BoundField DataField="ComputerName" HeaderText="ComputerName" SortExpression="ComputerName" />
                           
                           <asp:CommandField ButtonType="Button" ShowEditButton="True" ShowDeleteButton="True">
                           <ControlStyle BorderStyle="Dotted" />
                           </asp:CommandField>
                           
                       </Fields>
                       <RowStyle CssClass="data_row" VerticalAlign="Top" />
                   </asp:DetailsView>
                       </div>
            </div>
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                    SelectCommand="SELECT * FROM [Assets] WHERE ([AssetID] = @AssetID)" 
                    DeleteCommand="DELETE FROM [Assets] WHERE [AssetID] = @AssetID" 
                    InsertCommand="INSERT INTO [Assets] ([AssetDescription], [EmployeeID], [AssetCategoryID], [StatusID], [DepartmentID], [VendorID], [Make], [ModelNumber], [SerialNumber], [DateAcquired], [DateSold], [PurchasePrice], [DepreciationMethod], [DepreciableLife], [SalvageValue], [CurrentValue], [Comments], [Description], [NextSchedMaint], [Processor], [RAM], [Condition], [ComputerName], [SSMA_TimeStamp]) VALUES (@AssetDescription, @EmployeeID, @AssetCategoryID, @StatusID, @DepartmentID, @VendorID, @Make, @ModelNumber, @SerialNumber, @DateAcquired, @DateSold, @PurchasePrice, @DepreciationMethod, @DepreciableLife, @SalvageValue, @CurrentValue, @Comments, @Description, @NextSchedMaint, @Processor, @RAM, @Condition, @ComputerName, @SSMA_TimeStamp)" 
                    UpdateCommand="UPDATE Assets SET AssetDescription = @AssetDescription, EmployeeID = @EmployeeID, AssetCategoryID = @AssetCategoryID, StatusID = @StatusID, DepartmentID = @DepartmentID, VendorID = @VendorID, Make = @Make, ModelNumber = @ModelNumber, SerialNumber = @SerialNumber, DateAcquired = @DateAcquired, DateSold = @DateSold, PurchasePrice = @PurchasePrice, DepreciationMethod = @DepreciationMethod, DepreciableLife = @DepreciableLife, SalvageValue = @SalvageValue, CurrentValue = @CurrentValue, Comments = @Comments, Description = @Description, NextSchedMaint = @NextSchedMaint, Processor = @Processor, RAM = @RAM, Condition = @Condition, ComputerName = @ComputerName WHERE (AssetID = @AssetID)">
                    <DeleteParameters>
                        <asp:Parameter Name="AssetID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="AssetDescription" Type="String" />
                        <asp:Parameter Name="EmployeeID" Type="Int32" />
                        <asp:Parameter Name="AssetCategoryID" Type="Int32" />
                        <asp:Parameter Name="StatusID" Type="Int32" />
                        <asp:Parameter Name="DepartmentID" Type="Int32" />
                        <asp:Parameter Name="VendorID" Type="Int32" />
                        <asp:Parameter Name="Make" Type="String" />
                        <asp:Parameter Name="ModelNumber" Type="String" />
                        <asp:Parameter Name="SerialNumber" Type="String" />
                        <asp:Parameter DbType="DateTime2" Name="DateAcquired" />
                        <asp:Parameter DbType="DateTime2" Name="DateSold" />
                        <asp:Parameter Name="PurchasePrice" Type="Decimal" />
                        <asp:Parameter Name="DepreciationMethod" Type="String" />
                        <asp:Parameter Name="DepreciableLife" Type="Single" />
                        <asp:Parameter Name="SalvageValue" Type="Decimal" />
                        <asp:Parameter Name="CurrentValue" Type="Decimal" />
                        <asp:Parameter Name="Comments" Type="String" />
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter DbType="DateTime2" Name="NextSchedMaint" />
                        <asp:Parameter Name="Processor" Type="String" />
                        <asp:Parameter Name="RAM" Type="String" />
                        <asp:Parameter Name="Condition" Type="String" />
                        <asp:Parameter Name="ComputerName" Type="String" />
                        <asp:Parameter Name="SSMA_TimeStamp" Type="Object" />
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TextBox2" Name="AssetID" PropertyName="Text" Type="Int32" />
                    </SelectParameters>

                    
                    <UpdateParameters>
                        <asp:Parameter Name="AssetDescription" Type="String" />
                        <asp:Parameter Name="EmployeeID" Type="Int32" />
                        <asp:Parameter Name="AssetCategoryID" Type="Int32" />
                        <asp:Parameter Name="StatusID" Type="Int32" />
                        <asp:Parameter Name="DepartmentID" Type="Int32" />
                        <asp:Parameter Name="VendorID" Type="Int32" />
                        <asp:Parameter Name="Make" Type="String" />
                        <asp:Parameter Name="ModelNumber" Type="String" />
                        <asp:Parameter Name="SerialNumber" Type="String" />
                        <asp:Parameter DbType="DateTime2" Name="DateAcquired" />
                        <asp:Parameter DbType="DateTime2" Name="DateSold" />
                        <asp:Parameter Name="PurchasePrice" Type="Decimal" />
                        <asp:Parameter Name="DepreciationMethod" Type="String" />
                        <asp:Parameter Name="DepreciableLife" Type="Single" />
                        <asp:Parameter Name="SalvageValue" Type="Decimal" />
                        <asp:Parameter Name="CurrentValue" Type="Decimal" />
                        <asp:Parameter Name="Comments" Type="String" />
                        <asp:Parameter Name="Description" Type="String" />
                        <asp:Parameter DbType="DateTime2" Name="NextSchedMaint" />
                        <asp:Parameter Name="Processor" Type="String" />
                        <asp:Parameter Name="RAM" Type="String" />
                        <asp:Parameter Name="Condition" Type="String" />
                        <asp:Parameter Name="ComputerName" Type="String" />
                        <asp:Parameter Name="AssetID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <br />
                <br />
                <br />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
&nbsp; 
</asp:Content>

