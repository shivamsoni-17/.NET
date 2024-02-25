<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpdateMarks.ascx.cs" Inherits="Web_Student_Entry_System.UpdateMarks" %>


    <style>
        .form-group {
            margin-bottom: 15px;
        }
        label {
            font-weight: bold;
            color: #000066;
            margin-right: 10px;
        }
        .mandatory {
            color: red;
        }
        .button {
            padding: 10px 20px;
            color: white;
            background-color: #228B22;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            margin-right: 10px;
        }
        .button:hover {
            background-color: #32CD32;
        }
        .container {
            background-color: #f0f0f0;
            padding: 20px;
            border-radius: 5px;
        }
    </style>

    <form id="form1">
        <div class="container">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Reg. No *:"></asp:Label>
                <asp:TextBox ID="TextBoxRegNo" runat="server"></asp:TextBox>
                <span class="mandatory">*</span>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Semester:"></asp:Label>
                <asp:TextBox ID="TextBoxSemester" runat="server"></asp:TextBox>
            </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="All (*) marked fields are mandatory" CssClass="mandatory"></asp:Label>
            </div>
            <asp:Button ID="Button1" runat="server" Text="Show Marks" CssClass="button" OnClick="ButtonShowMarks_Click" />
            <br />
            <br />
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="MAD:"></asp:Label>
                <asp:TextBox ID="TextBoxMAD" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Platform Technology:"></asp:Label>
                <asp:TextBox ID="TextBoxPlatformTechnology" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="IEM:"></asp:Label>
                <asp:TextBox ID="TextBoxIEM" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="ATCD:"></asp:Label>
                <asp:TextBox ID="TextBoxATCD" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Computer Networks:"></asp:Label>
                <asp:TextBox ID="TextBoxComputerNetworks" runat="server"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                
                <br />
            <div class="form-group">
                <asp:Button ID="Button2" runat="server" Text="Clear" CssClass="button" OnClick="ButtonClear_Click" />
                <asp:Button ID="Button3" runat="server" Text="Update" CssClass="button" OnClick="ButtonUpdate_Click" />
            </div>
            
        </div>
    </form>


