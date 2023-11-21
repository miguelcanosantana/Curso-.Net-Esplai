<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebHangman._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <asp:Image ID="HangmanImage" runat="server" ImageUrl="~/Images/0.png" />
        <asp:Label ID="LivesLabel" runat="server" Text="Placeholder Lives: 9" ForeColor="#FFCC66"></asp:Label>
        <asp:Label ID="GuessedWordLabel" runat="server" Text="Placeholder Guessed Word" ForeColor="#FFCC00"></asp:Label>
        <asp:TextBox ID="InputTextBox" runat="server"></asp:TextBox>
        <asp:Label ID="WinLabel" runat="server" Text="" ForeColor="#FFCC66"></asp:Label>
        <asp:Label ID="LoseLabel" runat="server" Text="" ForeColor="#FFCC66"></asp:Label>


        <asp:Button ID="CheckButton" runat="server" Text="Try!" OnClick="CheckButton_Click" />


    </main>

</asp:Content>
