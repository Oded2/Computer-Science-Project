<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Odedprojectpleasework.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="script.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Flight Log Website</h1>
    <div class="images">
      <div class="image_holder">
        <img id="mainImage" src="Images/image1.jpeg" alt="Image" />
      </div>
      <div>
        <p>
          <span onclick="moveimage(-1)">Back</span>
          <span onclick="moveimage(1)">Next</span>
        </p>
      </div>
    </div>
    <div class="textHolder">
        <h1>Log your flights.</h1>
        <h1>Easy.</h1>
        <h1>Fast.</h1>
        <h1>Reliable.</h1>
    </div>
</asp:Content>
