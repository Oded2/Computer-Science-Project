<%@ Page Title="" Language="C#" MasterPageFile="main.Master"
AutoEventWireup="true" CodeBehind="flights.aspx.cs"
Inherits="Odedprojectpleasework.flights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  runat="server"
>
  <div class="content">
    <table class="" runat="server" id="logbook">
      <thead>
        <tr>
          <th rowspan="2">Date</th>
          <th rowspan="2">Duration</th>
          <th colspan="2">Departure</th>
          <th colspan="2">Landing</th>
          <th colspan="3">Aircraft</th>
          <th rowspan="2">Notes</th>
          <th rowspan="2">Actions</th>
        </tr>
        <tr>
          <th>Time</th>
          <th>Airport</th>
          <th>Time</th>
          <th>Airport</th>
          <th>Type</th>
          <th>Model</th>
          <th>Callsign</th>
        </tr>
      </thead>
      <tbody></tbody>
    </table>
  </div>
</asp:Content>
