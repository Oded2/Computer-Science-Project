﻿<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master"
AutoEventWireup="true" CodeBehind="signup.aspx.cs"
Inherits="Odedprojectpleasework.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            <td>ID</td>
            <td>
              <input type="text" id="id" name="id" maxlength="10" />
            </td>
            <td>Create a password</td>
            <td>
              <input
                type="password"
                name="password"
                id="password"
                maxlength="20"
              />
            </td>
          </tr>
          <tr>
            <td>First name</td>
            <td>
              <input type="text" id="fname" name="fname" maxlength="50" />
            </td>
            <td>GPA</td>
            <td>
              <input type="number" id="gpa" name="gpa" max="5" min="0" />
            </td>
          </tr>
          <tr>
            <td>Last name</td>
            <td>
              <input type="text" id="lname" name="lname" maxlength="50" />
            </td>
            <td>Email</td>
            <td>
              <input type="email" name="email" id="email" maxlength="50" />
            </td>
          </tr>
          <tr>
            <td>Phone number</td>
            <td>
              <input type="tel" name="tel" id="tel" maxlength="10" />
            </td>
            <td>Recieve mailing?</td>
            <td>
              <input type="checkbox" name="spam" id="spam" />
            </td>
          </tr>
          <tr>
            <td>Address</td>
            <td>
              <input type="text" name="address" id="address" maxlength="50" />
            </td>
            <td>Date of birth</td>
            <td>
              <input type="date" name="dob" id="dob" />
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
  </form>
</asp:Content>