<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherInterface.aspx.cs" Inherits="Web_Student_Entry_System.TeacherInterface" %>

<%@ Register src="EnterMarks.ascx" tagname="EnterMarks" tagprefix="uc1" %>

<%@ Register src="All.ascx" tagname="All" tagprefix="uc2" %>

<%@ Register src="UpdateMarks.ascx" tagname="UpdateMarks" tagprefix="uc3" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Interface</title>
    <style type="text/css">
        .header {
            background-color: #007ACC;
            color: white;
            font-size: 26px;
            font-weight: bold;
            padding: 20px;
            text-align: center;
        }
        .menu {
            padding: 10px;
            background-color: #D3D3D3;
            text-align: center;
            height: 36px;
            width: 1776px;
        }
        .menubt {
            margin: 0 10px;
            text-decoration: none;
            font-size: 18px;
            color: black;
        }
        .main-content {
            margin: 20px;
            padding: 20px;
            background-color: #E8E8E8;
            height: 937px;
            width: 1726px;
        }
        .logout-button {
            float: right;
            margin: 20px;
            padding: 5px 10px;
            background-color: #F8F8F8;
            border: 1px solid #C0C0C0;
            cursor: pointer;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
        <div class="header">
            Student's Marks Entry System
            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="logout-button" OnClick="btnLogout_Click" Height="38px" Width="92px" />
        </div>
        <div class="menu">

            <asp:Button ID="Button1" runat="server" Text="Enter Marks" CssClass="menubt" OnClick="EnterMarks_Click" />
            <asp:Button ID="Button2" runat="server" Text="Update Marks" CssClass="menubt" OnClick="UpdateMarks_Click" />
            <asp:Button ID="Button3" runat="server" Text="View Marks" CssClass="menubt" OnClick="AllMarks_Click" />

        </div>
         <uc3:UpdateMarks ID="UpdateMarks1" runat="server" Visible="False" />
        <uc2:All ID="All1" runat="server" Visible="False" />
        <uc1:EnterMarks ID="EnterMarks1" runat="server" Visible="False" />
        </form>
        
            
            
    </body>
</html>

