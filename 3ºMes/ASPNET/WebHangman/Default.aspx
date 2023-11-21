<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebHangman._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <asp:Image ID="HangmanImage" runat="server" ImageUrl="~/Images/0.png" />
        <asp:Label ID="LivesLabel" runat="server" Text="Placeholder Lives: 9"></asp:Label>
        <asp:Label ID="GuessedWordLabel" runat="server" Text="Placeholder Guessed Word"></asp:Label>
        <asp:TextBox ID="InputTextBox" runat="server"></asp:TextBox>


    </main>

</asp:Content>
