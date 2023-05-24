<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Odedprojectpleasework.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="parent">
    <div class="main">
      <div class="third">
          <h2>ID</h2>
          <input type="text" name="id" id="id" maxlength="10" />
          <h2>Password</h2>
          <input type="password" name="password" id="password" maxlength="20" />
          <h2></h2>
          <input type="submit" id="submit" name="submit" value="Log In" />
        <div class="loginToSignup">
          <h3>Want to create an account? <a href="signup.aspx">Sign Up!</a></h3>
        </div>
      </div>
    </div>
  </div>
</asp:Content>
