<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web_Student_Entry_System.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <style>
        /* Add your CSS styles here */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 24%;
            margin: 50px auto;
            background-color: #fff;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            height: 619px;
        }
        h2 {
            text-align: center;
            color: #333;
        }
        .form-group {
            align-content:center;
            margin-bottom: 10px;
            width: 415px;
        }
        .form-group label {
            display: block;
            margin-bottom: 5px;
            width: 154px;
        }
        .form-group input[type="text"],
        .form-group input[type="password"],
        .form-group input[type="email"] {
            width: 85%;
            padding: 8px;
            border: 1px solid #ddd;
            border-radius: 4px;
        }
        .form-group input[type="submit"],
        .form-group input[type="reset"] {
            padding: 10px 15px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .form-group input[type="submit"] {
            background-color: #5cb85c;
            color: white;
        }
        .form-group input[type="reset"] {
            align-content: center;
            background-color: #f0ad4e;
            color: white;
        }
        .mandatory {
            color: red;
            font-size: 0.8em;
        }
        .radioButtonList input[type="radio"] {
            margin-right: 10px;
        }
    </style>
</head>
<body>
    <form id="registrationForm" runat="server">
        <div class="container">
            <h2>REGISTRATION</h2>
            <div class="form-group">
                <label for="fullName">Full Name<span class="mandatory">*</span>:</label>
                <asp:TextBox ID="fullName" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label>Gender<span class="mandatory">*</span>:</label>
                <asp:RadioButtonList ID="gender" runat="server" RepeatDirection="Horizontal" CssClass="radioButtonList">
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                    <asp:ListItem Text="Other" Value="Other" />
                </asp:RadioButtonList>
            </div>
            <div class="form-group">
                <label for="email">Email:</label>
                <asp:TextBox ID="email" runat="server" TextMode="Email" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label>Role<span class="mandatory">*</span>:</label>
                <asp:RadioButtonList ID="role" runat="server" RepeatDirection="Horizontal" CssClass="radioButtonList">
                    <asp:ListItem Text="Student" Value="Student" />
                    <asp:ListItem Text="Teacher" Value="Teacher" />
                </asp:RadioButtonList>
            </div>
            <div class="form-group">
                <label for="username">Username<span class="mandatory">*</span>:</label>
                <asp:TextBox ID="username" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="password">Password:</label>
                <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control" />
            </div>
            <center>
                <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
            </center>
            <div class="form-group">
                <center>
                    <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" CssClass="btn btn-warning" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="btn btn-success" />
                </center>
                
            </div>
            <p class="mandatory">All (*) marked fields are mandatory</p>
        </div>
    </form>
</body>
</html>
