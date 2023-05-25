<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master"
AutoEventWireup="true" CodeBehind="unreachable.aspx.cs"
Inherits="Odedprojectpleasework.unreachable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link rel="stylesheet" href="style.css" />
  <script src="unreachableScript.js"></script>
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  runat="server"
>
  <div class="unreachableParent">
    <h1>Hold on!</h1>
    <h2>Please <a href="login.aspx">Login</a></h2>
    <img src="Images/airplane.png" alt="Airplane" />
    <div class="unreachableRedirect">
      <span> Redirecting in: <span id="timer"></span> seconds </span>
    </div>
  </div>
</asp:Content>
