<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="Odedprojectpleasework.gallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Gallery/gallery.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="intro"> 
      <h2>Image Gallery</h2> 
      <p>Select a thumbnail below to view the image</p> 
    </div> 
    <div id="image-gallery">
      <img id="current-image" src="Gallery/images/image (1).jpeg" alt="Image 1" >
    </div>
    <div id="image-nav">
      <span onclick="moveImage(-1)" class="navButton">&lt;&lt;</span>
      &nbsp;&nbsp;&nbsp;
      <span onclick="moveImage(1)" class="navButton">&gt;&gt;</span>
    </div>
    <div id="image-thumbs"></div>
    <script src="Gallery/gallery.js"></script>
</asp:Content>
