<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="People.aspx.cs" Inherits="ToDoItemAddedASMX._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Contact Details</h1>

        <asp:Xml ID="peopleXML" runat="server"/>
    </div>

</asp:Content>
