<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master"
AutoEventWireup="true" CodeBehind="signup.aspx.cs"
Inherits="Odedprojectpleasework.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <script src="script.js"></script>
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  runat="server"
>
  <form method="post" onsubmit="return validateSignupForm()">
    <div class="parent">
      <h1>Sign up</h1>
      <div class="main">
        <div id="divError" class="divError" runat="server"></div>

        <table class="content">
          <tr>
            <th>ID</th>
            <td>
              <input type="text" id="id" name="id" maxlength="10" required value="<%=Request.Form["id"] %>" />
            </td>
            <th>Create a password</th>
            <td>
              <input
                type="password"
                name="password"
                id="password"
                maxlength="20"
                 value="<%=Request.Form["password"] %>"
              />
            </td>
          </tr>
          <tr>
            <th>First name</th>
            <td>
              <input
                type="text"
                id="fname"
                name="fname"
                maxlength="50"
                placeholder=""
                  value="<%=Request.Form["fname"] %>"
                required
              />
            </td>
            <th>GPA</th>
            <td>
              <input type="number" id="gpa" name="gpa" max="5" min="0"  step=".01" value="<%=Request.Form["gpa"] %>" required/>
            </td>
          </tr>
          <tr>
            <th>Last name</th>
            <td>
              <input type="text" id="lname" name="lname" maxlength="50" value="<%=Request.Form["lname"] %>" required"/>
            </td>
            <th>Email</th>
            <td>
              <input type="email" name="email" id="email" maxlength="50" value="<%=Request.Form["email"] %>" required />
            </td>
          </tr>
          <tr>
            <th>Phone number</th>
            <td>
              <input type="tel" name="tel" id="tel" maxlength="10" value="<%=Request.Form["tel"] %>" required/>
            </td>
            <th>Recieve mailing?</th>
            <td>
              <input type="checkbox" name="spam" id="spam" />
            </td>
          </tr>
          <tr>
            <th>Address</th>
            <td>
              <input type="text" name="address" id="address" maxlength="50" value="<%=Request.Form["address"] %>" required />
            </td>
            <th>Date of birth</th>
            <td>
              <input type="date" name="dob" id="dob" min="1900-01-01" value="<%=Request.Form["dob"] %>" required />
            </td>
          </tr>
          <tr>
            <td colspan="2">
              <input type="reset" />
            </td>

            <td colspan="2">
              <input type="submit" id="submit" name="submit" />
            </td>
          </tr>
          <tr>
            <td colspan="4">
              <h3>Already have an account? <a href="login.aspx">Login!</a></h3>
            </td>
          </tr>
        </table>
      </div>
    </div>
  </form></asp:Content
>
