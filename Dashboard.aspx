<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Purchase_Management.WebForm1" %>

<!DOCTYPE html>











<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/style.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css">
<script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 100%;
            left: 0px;
            top: 0px;
            height: 144px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image2" runat="server" Height="169px" ImageUrl="~/Images/logo.png" Width="211px" />
<div id="wrapper" class="active">
      
      
      <!-- Sidebar -->
            <!-- Sidebar -->
      <div id="sidebar-wrapper">
      <ul id="sidebar_menu" class="sidebar-nav">
           <li class="sidebar-brand"><a id="menu-toggle" href="#">Dashboard<span id="main_icon" class="glyphicon glyphicon-align-justify"></span></a></li>
      </ul>
        <ul class="sidebar-nav" id="sidebar">  
            <asp:TextBox ID="TextBox1" runat="server" BackColor="#252525" BorderColor="#CCCCCC" BorderStyle="Solid" CssClass="search" ForeColor="White" placeholder="Search"></asp:TextBox>   
          <li>
              <a>Assets<span class="sub_icon glyphicon glyphicon-briefcase"></span></a></li>
          <li><a>Employees<span class="sub_icon glyphicon glyphicon-user"></span></a></li>
            <li><a>Purchase<span class="sub_icon glyphicon glyphicon-user"></span></a></li>
        </ul>
      </div>
    <asp:Image ID="Image1" runat="server" />   
      <!-- Page content -->
      <div id="page-content-wrapper">
        <!-- Keep all page content within the page-content inset div! -->
        <div class="page-content inset">
          <div class="row">
              <div class="auto-style1">
              <p class="well lead">Content here and links of data</p>
              <p class="well lead">Sub-content here and links of data</p> 
            </div>
          </div>
        </div>
      </div>
      
    </div>


  </form>   
</body>
</html>
