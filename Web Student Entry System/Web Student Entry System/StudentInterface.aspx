<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInterface.aspx.cs" Inherits="Web_Student_Entry_System.StudentInterface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student's Marks Entry System</title>
    <style>
        body {
            background-color: #D3D3D3;
            font-family: Arial, sans-serif;
        }
        .container {
            width: 80%;
            margin: auto;
            background-color: #F0F0F0;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        .header {
            font-size: 26px;
            font-weight: bold;
            text-align: center;
            margin-bottom: 20px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        label {
            display: block;
            margin-bottom: 5px;
            color: #000080;
        }
        input[type="text"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ccc;
        }
        .button {
            padding: 10px 20px;
            background-color: #228B22;
            color: white;
            border: none;
            cursor: pointer;
        }
        .button:hover {
            background-color: #2E8B57;
        }
        .logout-button {
            float:right;
            background-color: #F8F8F8;
            color: black;
            padding: 5px 10px;
            text-align: right;
            display: block;
        }
    </style>
</head>
<body>
    <form class="form-group" runat="server">

    <div class="container">
        <div class="header">
            Student's Marks Entry System
        </div>
        <asp:Button ID="buttonLogout" runat="server" CssClass="logout-button" Text="Logout" OnClick="buttonLogout_Click" />
        <br />
        <br />
        <div class="form-group">
            <label for="TextBoxRegNo">Reg. No *:</label>
            <asp:TextBox ID="TextBoxRegNo" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="buttonClear" runat="server" CssClass="button" Text="Clear" OnClick="buttonClear_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="buttonShowMarks" runat="server" CssClass="button" Text="Show Marks" OnClick="buttonShowMarks_Click" />
        </div>
        <div class="form-group">
            <label for="TextBoxName">Name:</label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBoxSemester">Semester:</label>
            <asp:TextBox ID="TextBoxSemester" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBoxMAD">MAD:</label>
            <asp:TextBox ID="TextBoxMAD" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBoxPlatformTechnology">Platform Technology:</label>
            <asp:TextBox ID="TextBoxPlatformTechnology" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBoxIEM">IEM:</label>
            <asp:TextBox ID="TextBoxIEM" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBoxATCD">ATCD:</label>
            <asp:TextBox ID="TextBoxATCD" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBoxComputerNetworks">Computer Networks:</label>
            <asp:TextBox ID="TextBoxComputerNetworks" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    </div>
</form>
</body>
</html>
