<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div class="row">

            <asp:Button ID="TestButton" runat="server" Text="Test Button" OnClick="TestButton_Click" />
            
            <asp:ListBox ID="WeekDayListBox" AutoPostBack="True" runat="server" Width="494px" OnSelectedIndexChanged="WeekDayListBox_SelectedIndexChanged">
                <asp:ListItem Selected="True">Select a Day</asp:ListItem>
                <asp:ListItem>Monday</asp:ListItem>
                <asp:ListItem>Tuesday</asp:ListItem>
                <asp:ListItem>Wednesday</asp:ListItem>
                <asp:ListItem>Thursday</asp:ListItem>
                <asp:ListItem>Friday</asp:ListItem>
                <asp:ListItem>Saturday</asp:ListItem>
                <asp:ListItem>Sunday</asp:ListItem>
            </asp:ListBox>

            <asp:Label ID="WeekDayLabel" runat="server" Text="Select a Day"></asp:Label>


        </div>
    </main>

</asp:Content>
