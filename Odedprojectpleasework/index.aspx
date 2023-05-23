<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master"
AutoEventWireup="true" CodeBehind="index.aspx.cs"
Inherits="Odedprojectpleasework.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <script src="script.js"></script>
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  runat="server"
>
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
  <div class="homeMain">
    <h1>Welcome to AeroLogger!</h1>
    <p>
      The ultimate online platform for student pilots to log their flights and
      track their progress!
    </p>
    <p>
      Our user-friendly interface provides a seamless experience, allowing you
      to easily record and manage your flight hours with just a few clicks.
    </p>
    <p>
      Whether you're a beginner or an aspiring professional pilot, our website
      offers a comprehensive solution to help you stay organized and motivated
      on your aviation journey.
    </p>
    <p>
      Explore our features, log your flights, and gain valuable insights into
      your training.
    </p>
    <p>
      Start logging your flights today and take your pilot training to new
      heights!
    </p>
  </div>
</asp:Content>
