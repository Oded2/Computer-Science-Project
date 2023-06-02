<%@ Page Title="" Language="C#" MasterPageFile="main.Master"
AutoEventWireup="true" CodeBehind="flightlogger.aspx.cs"
Inherits="Odedprojectpleasework.flightlogger" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <script src="../javascriptscript.js"></script>
  <script src="../javascript/flightlogger.js"></script>
</asp:Content>
<asp:Content
  ID="Content2"
  ContentPlaceHolderID="ContentPlaceHolder1"
  runat="server"
>
  <div class="logParent">
    <div class="logMain">
      <form runat="server" onsubmit="return validateFlightLog()">
        <table>
          <tr>
            <td>Date</td>
            <td>
              <input
                type="date"
                name="logDate"
                id="logDate"
                min="1900-01-01"
                max=""
                onclick="maxDay()"
                value=""
              />
            </td>
            <td>Aircraft callsign</td>
            <td>
              <input type="text" name="callsign" id="callsign" maxlength="7" />
            </td>
          </tr>
          <tr>
            <td>Time of Departure</td>
            <td>
              <input type="time" name="logTakeoff" id="logTakeoff" />
            </td>
            <td>Airport of Departure</td>
            <td>
              <select
                runat="server"
                name="logAirportTakeoff"
                id="logAirportTakeoff"
              ></select>
            </td>
          </tr>
          <tr>
            <td>Time of Landing</td>
            <td>
              <input type="time" name="logLanding" id="logLanding" value="" />
            </td>
            <td>Airport of Destination</td>
            <td>
              <select
                runat="server"
                name="logAirportLanding"
                id="logAirportLanding"
              ></select>
            </td>
          </tr>
          <tr>
            <td>Type of Aircraft</td>
            <td>
              <select name="logAirType" id="logAirType">
                <option value="Airplane" selected>Airplane</option>
                <option value="Helicopter">Helicopter</option>
                <option value="Gliders">Glider</option>
                <option value="Balloon">Balloon</option>
                <option value="Blimp">Blimp</option>
                <option value="Drone">Drone</option>
                <option value="Other">Other</option>
              </select>
            </td>
            <td>Model of Aircraft</td>
            <td>
              <input type="text" name="logModel" id="logModel" maxlength="50" />
            </td>
          </tr>
          <tr>
            <td>Notes</td>
            <td colspan="3">
              <textarea name="logNotes" id="logNotes"></textarea>
            </td>
          </tr>
        </table>

        <div class="logButton">
          <button type="submit" id="submit" name="submit">Submit</button>
        </div>
      </form>
    </div>
  </div>
</asp:Content>
