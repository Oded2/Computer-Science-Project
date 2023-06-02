<%@ Page Title="" Language="C#" MasterPageFile="main.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Odedprojectpleasework.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="adminParent">
      <div class="content">
        <table class="" runat="server" id="tblUsers">
          <tr>
            <th>Id</th>
            <th>First name</th>
            <th>Last name</th>
            <th>Telephone</th>
            <th>Address</th>
            <th>Date of Birth</th>
            <th>GPA</th>
            <th>Email Address</th>
            <th>Recieving mailing?</th>
            <th>Admin?</th>
            <th>Action</th>
          </tr>
        </table>
      </div>
    </div>
</asp:Content>
