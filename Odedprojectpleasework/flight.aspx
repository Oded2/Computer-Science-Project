﻿<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master"
AutoEventWireup="true" CodeBehind="flight.aspx.cs"
Inherits="Odedprojectpleasework.flight" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <script src="script.js"></script>
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  runat="server"
>
  <form runat="server">
    <div class="flightParent">
      <div class="flightTitle">
        <h1>
          Flight on
          <span id="flightDate" runat="server"
            >the date the flight happened</span
          >
        </h1>
      </div>
      <div class="flightMap"><h1>[INSERT FLIGHT MAP HERE]</h1></div>
      <div class="flightNoteTitle"><h1>Your Notes</h1></div>
      <div class="flightNotes">
        <p runat="server" id="notes">
          Very fun flight, I really enjoyed it, I am currently typing, and I am
          writing HTML. This project is not fun at all blah blah blahVery fun
          flight, I really enjoyed it, I am currently typing, and I am writing
          HTML. This project is not fun at all blah blah blahVery fun flight, I
          really enjoyed it, I am currently typing, and I am writing HTML. This
          project is not fun at all blah blah blah
        </p>
      </div>
      <div class="flightInfo">
        <h1>
          <span runat="server" id="airportTakeoff"
            >Airport you took off from</span
          >
          ->
          <span runat="server" id="airportLanding">Airport you landed in</span>
        </h1>
        <br />
        <p>
          Total Flight Time:
          <span runat="server" id="duration">Duration of your flight</span>
        </p>
        <p class="left">
          Aircraft:
          <span id="model" runat="server">Model of your aircraft</span>
          <span id="callsign" runat="server"> callsign of your aircraft</span>
        </p>
        <br />
        <button
          id="delete"
          class="deleteFlight"
          onclick="return deleteFlight(<%=fligthId%>)"
        >
          Delete Flight
        </button>
      </div>
    </div>
  </form>
</asp:Content>
