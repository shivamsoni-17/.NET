<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_Student_Entry_System.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
    <style>
        body {
            background-color: #e0e0e0;
            font-family: Arial, sans-serif;
            height: 478px;
        }
        .container {
            width: 312px;
            margin: 100px auto;
            padding: 20px;
            background-color: #f0f0f0;
            border: 1px solid #ddd;
            border-radius: 5px;
            box-shadow: 2px 2px 5px rgba(0,0,0,0.2);
            height: 338px;
        }
        h2 {
            text-align: center;
            color: #333;
        }
        .form-group {
            margin-bottom: 15px;
            width: 296px;
        }
        .form-group label {
            align-content:center;
            display: block;
            margin-bottom: 5px;
        }
        .form-group input[type="text"],
        .form-group input[type="password"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ddd;
            border-radius: 3px;
        }
        .form-group input[type="submit"],
        .form-group input[type="reset"] {
            width: 100px;
            padding: 10px;
            margin-right: 10px;
            border: none;
            border-radius: 3px;
            color: white;
            background-color: #5cb85c; /* Green */
            cursor: pointer;
        }
        .form-group input[type="reset"] {
            background-color: #d9534f; /* Red */
        }
        .register-link {
            text-align: center;
            display: block;
            margin-top: 15px;
        }
    </style>
</head>

<body>
    <form id="loginForm" runat="server">
        <div class="container">
            <h2>WELCOME</h2>
            <div class="form-group">
                <label for="username">Username:</label>
                <asp:TextBox ID="UsernameTextBox" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="password">Password:</label>
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" CssClass="form-control" />
            </div>
            <div class="form-group">
                <br />
                <center>
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="Clear_Click" CssClass="btn btn-default" />
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Login_Click" CssClass="btn btn-primary" />
                </center>
                
            </div>
            <center>
                <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
            </center>
            
            <div class="register-link">
                <asp:HyperLink ID="registerLink" runat="server" NavigateUrl="~/Register.aspx">New user registration. Click here</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
