<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EnterMarks.ascx.cs" Inherits="Web_Student_Entry_System.EnterMarks" %>

    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f0f0f0;
            margin: 0;
            padding: 20px;
        }
        .container {
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            padding: 20px;
            max-width: 800px;
            margin: auto;
        }
        .group {
            margin-bottom: 20px;
        }
        .group label {
            display: block;
            margin-bottom: 5px;
            color: #333;
        }
        .group input[type="text"] {
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .button-group {
            text-align: right;
        }
        .button-group button {
            padding: 10px 20px;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .clear-button {
            background-color: #008CBA;
        }
        .save-button {
            background-color: #4CAF50;
        }
        .mandatory {
            color: red;
            font-size: 0.8em;
            text-align: center;
            margin-top: 20px;
        }
    </style>
    <form id="form1">
        <div class="container">
            <div class="group">
                <h2>Student Details:</h2>
                <label for="TextBox1">Name *:</label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Width="295px"></asp:TextBox>
                <label for="TextBox2">Reg. No *:</label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Width="295px"></asp:TextBox>
                <label for="TextBox3">Semester *:</label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Width="295px"></asp:TextBox>
            </div>
            <div class="group">
                <h2>Marks:</h2>
                <label for="TextBox4">MAD *:</label>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Width="295px"></asp:TextBox>
                <label for="TextBox5">Platform Technology *:</label>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" Width="295px"></asp:TextBox>
                <label for="TextBox6">IEM *:</label>
                <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" Width="295px"></asp:TextBox>
                <label for="TextBox7">ATCD *:</label>
                <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" Width="295px"></asp:TextBox>
                <label for="TextBox8">Computer Networks *:</label>
                <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control" Width="293px"></asp:TextBox>
            </div>
            <div runat="server" id="errorMessage">
                <asp:Label ID="LabelMessage" runat="server"></asp:Label>
            </div>
            <div class="error"></div>
            <div class="button-group">
                <center>
                    <asp:Button ID="ButtonClear" runat="server" Text="Clear" CssClass="clear-button" OnClick="ButtonClear_Click" Height="49px" Width="90px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonSave" runat="server" Text="Save" CssClass="save-button" OnClick="ButtonSave_Click" Height="50px" Width="81px" />
                </center>
                
            </div>
            
        </div>
    </form>
