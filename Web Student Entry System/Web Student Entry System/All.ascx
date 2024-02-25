<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="All.ascx.cs" Inherits="Web_Student_Entry_System.All" %>

    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f0f0f0;
        }
        .container {
            padding: 20px;
        }
        .grid-view {
            font-size: 16px;
            width: 100%;
            margin-top: 20px;
        }
        .button {
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            background-color: #007ACC;
        }
        .grid-view th {
            background-color: #4CAF50;
            color: white;
        }
        .grid-view td, .grid-view th {
            border: 1px solid #ddd;
            padding: 8px;
        }
        .grid-view tr:nth-child(even){background-color: #f2f2f2;}
        .grid-view tr:hover {background-color: #ddd;}
    </style>

    <form id="form1">
        <div class="container">
            <asp:GridView ID="GridViewStudents" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="RegisterNo" HeaderText="Register No" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Semester" HeaderText="Semester" />
                <asp:BoundField DataField="MAD" HeaderText="MAD" />
                <asp:BoundField DataField="IEM" HeaderText="IEM" />
                <asp:BoundField DataField="Platform_Technology" HeaderText="Platform Technology" />
                <asp:BoundField DataField="Computer_Networks" HeaderText="Computer Networks" />
                <asp:BoundField DataField="ATCD" HeaderText="ATCD" />
            </Columns>
            </asp:GridView>
            <asp:Label ID="LabelMessage" runat="server" />
            <br />
            <br />
            <asp:Button ID="ButtonRefresh" runat="server" Text="Refresh" CssClass="button" OnClick="ButtonRefresh_Click" Height="48px" Width="121px" />
        </div>
    </form>
