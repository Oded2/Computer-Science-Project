<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="flights.aspx.cs" Inherits="Odedprojectpleasework.flights" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="myFLmain">
        <table class="myFLmain">
            <tr class="FL">
                <td>
                    <h2>Date</h2>
                </td>
                <td>
                    <h2>Total Flight Time</h2>
                </td>
                <td>
                    <h2>Time of Departure</h2>
                </td>
                <td>
                    <h2>Airport of Departure</h2>
                </td>
                <td>
                    <h2>Time of Landing</h2>
                </td>
                <td>
                    <h2>Airport of Destination</h2>
                </td>
                <td>
                    <h2>Type of Aircraft</h2>
                </td>
                <td>
                    <h2>Model of Aircraft</h2>
                </td>
                <td>
                    <h2>Identification of Aircraft</h2>
                </td>
                <td>
                    <h2>Notes</h2>
                </td>

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
                <td>Charlie Hotel Alpha</td>
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


        </table>
    </div>
</asp:Content>
