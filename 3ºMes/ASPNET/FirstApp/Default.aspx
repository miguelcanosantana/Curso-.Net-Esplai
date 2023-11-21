<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div class="row">

            <asp:Button ID="TestButton" runat="server" Text="Test Button" OnClick="TestButton_Click" />

        </div>
    </main>

</asp:Content>
