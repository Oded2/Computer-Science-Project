<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs"
  Inherits="Odedprojectpleasework.login" %>
  <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  </asp:Content>
  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
      <h1>Please log in</h1>
      <div class="main">
        <table class="content">
          <tr>
            <th>
              ID:
            </th>
            <td><input type="text" name="id" id="id" maxlength="10" placeholder="ID"></td>
          </tr>
          <tr>
            <th>
              Password:
            </th>
            <td>
              <input type="password" class="form-control" name="password" id="password" maxlength="20"
                placeholder="Password">
            </td>
          </tr>
          <tr>
            <td colspan="2">
              <input type="submit" name="submit" id="submit" value="Log In">
              <p>Not a member? <a href="signup.aspx">Sign Up</a></p>

            </td>
          </tr>
        </table>
      </div>
    </form>

  </asp:Content>