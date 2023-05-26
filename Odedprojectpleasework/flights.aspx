<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master"
AutoEventWireup="true" CodeBehind="flights.aspx.cs"
Inherits="Odedprojectpleasework.flights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  runat="server"
>
  <div class="container">
    <table class="table table-hover" runat="server" id="logbook">
      <thead>
        <tr class="table-primary">
          <th>Date</th>
          <th>Total Flight Time</th>
          <th>Time of Departure</th>
          <th>Airport of Departure</th>
          <th>Time of Landing</th>
          <th>Airport of Destination</th>
          <th>Type of Aircraft</th>
          <th>Model of Aircraft</th>
          <th>Aircraft Callsign</th>
          <th>Notes</th>
        </tr>
      </thead>
      <tbody></tbody>
    </table>
  </div>
</asp:Content>
