<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs"
    Inherits="Odedprojectpleasework.index" %>

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
          <td runat="server" id="tdHeader1"> <a href="myFlights.aspx">My Flights</a></td>
          <td class="pageName">Home</td>
          <td runat="server" id="tdHeader3" ><a href="Sign_Up.aspx">Sign Up</a></td>
        </tr>
      </table>
    </div>
    <h1>Flight Log Website</h1>
    <div class="images">
      <div class="image_holder">
        <img id="mainImage" src="" alt="Image" />
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
  </body>
</html>