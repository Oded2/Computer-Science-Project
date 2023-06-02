<%@ Page Title="" Language="C#" MasterPageFile="main.Master" AutoEventWireup="true" CodeBehind="flight.aspx.cs"
  Inherits="Odedprojectpleasework.flight" %>
  <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../javascript/script.js"></script>
    <script src="../javascript/flight.js"></script>
  </asp:Content>
  <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
      <div class="flightParent">
        <div class="flightTitle">
          <h1>
            Flight on
            <span id="flightDate" runat="server">the date the flight happened</span>
          </h1>
        </div>
        <div class="flightMap">
          <img src="../../Images/airportsmap.jpg" style="width: 408px; height: 750px">
        </div>
        <div class="flightNoteTitle">
          <h1>Your Notes</h1>
        </div>
        <div class="flightNotes">
          <p runat="server" id="notes">

          </p>
        </div>
        <div class="flightInfo">
          <h1>
            <span runat="server" id="airportTakeoff">Airport you took off from</span>
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
          <button id="delete" class="deleteFlight" onclick="return deleteFlight(<%=fligthId%>)">
            Delete Flight
          </button>
        </div>
      </div>
    </form>
  </asp:Content>