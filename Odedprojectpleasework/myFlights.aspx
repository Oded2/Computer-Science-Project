<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myFlights.aspx.cs" Inherits="Odedprojectpleasework.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
  <head runat="server">
    <meta charset="utf-8" />
    <title>Flight Log</title>
    <link rel="stylesheet" href="style.css" />
    <script src="script.js"></script>
  </head>
  <body onload="onLoad()">
    <div class="header">
      <table>
        <tr>
          <td runat="server" id="tdHeader1"><a href="index.aspx">Home</a></td>
          <td class="pageName">My Flights</td>
          <td runat="server" id="tdHeader3">
            <a href="Sign_Up.aspx">Sign Up</a> / <a href="Login.aspx">Login</a>
          </td>
        </tr>
      </table>
    </div>

    <div class="myFL">
      <h1>My Flights</h1>
    </div>
    <form id="form1" runat="server"></form>
    <h2>Hello [user]!</h2>
    <h3>Here are your flights</h3>
    <h2>Hits: <%=Application["hits"] %></h2>
    <div class="myFLmain">
      <table class="myFLmain">
        <tr class="FL">
          <td><h2>Date</h2></td>
          <td><h2>Total Flight Time</h2></td>
          <td><h2>Time of Departure</h2></td>
          <td><h2>Airport of Departure</h2></td>
          <td><h2>Time of Landing</h2></td>
          <td><h2>Airport of Destination</h2></td>
          <td><h2>Type of Aircraft</h2></td>
          <td><h2>Model of Aircraft</h2></td>
          <td><h2>Identification of Aircraft</h2></td>
          <td><h2>Notes</h2></td>

        </tr>
        <tr>
          <td>Date</td>
          <td>Hours, Minutes</td>
          <td>Time</td>
          <td>Airport</td>
          <td>Time</td>
          <td>Airport</td>
          <td>Aircraft, Helicopter, etc.</td>
          <td>Boeing 747, Cessna 172, etc.</td>
          <td>Charlie Hotel Alpha</td>
          <td>Normal</td>
        </tr>
        <tr>
          <td>December 12th, 2024</td>
          <td>1 Hour and 20 Minutes</td>
          <td>3:10PM</td>
          <td>KJFK</td>
          <td>4:30PM</td>
          <td>KATL</td>
          <td>Airplane</td>
          <td>Cessna 172</td>
          <td>Charlie Hotel Alpha</td>
          <td>Very fun flight. I would do it again. It was a little windy</td>
        </tr>



    </div>
  </body>
</html>
