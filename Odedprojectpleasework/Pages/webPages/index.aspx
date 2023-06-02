<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/webPages/main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs"
  Inherits="Odedprojectpleasework.index1" %>
  <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="style.css">
    <script src="../javascript/script.js"></script>
  </asp:Content>
  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
      <div class="left">
        <h1>AeroLogger</h1>
        <p>The ultimate online platform for student pilots to log their flights and
          track their progress!</p>
        <p>Our user-friendly interface provides a seamless experience, allowing you
          to easily record and manage your flight hours with just a few clicks.</p>
        <p>Whether you're a beginner or an aspiring profezssional pilot, our website
          offers a comprehensive solution to help you stay organized and motivated
          on your aviation journey.</p>
        <p>Explore our features, <a href="flightlogger.aspx">log</a> your flights, and gain valuable
          insights into
          your training.</p>
        <p>Start logging your <a href="flights.aspx">flights</a> today and take your pilot training
          to new
          heights!</p>
        <div>
          <button type="button" class="btn btn-outline-primary btn-lg px-4 me-md-2" onclick="contactUs()">Contact
            Us</button>


        </div>


      </div>
      <div class="right">
        <img src="../../Images/logo.png" id="mainImage" class="d-block mx-lg-auto img-fluid" alt="Bootstrap Themes"
        width="300"  loading="lazy">

      </div>
    </div>
      <h3>This site has been visited <%=totalVisits %> times</h3>
  </asp:Content>