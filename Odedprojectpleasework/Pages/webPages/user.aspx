<%@ Page Title="" Language="C#" MasterPageFile="main.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs"
    Inherits="Odedprojectpleasework.user" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script src="../javascript/script.js"></script>
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form runat="server" onsubmit="return validateUserEdit()">
            <div>
                <table class="content">
                    <tr>
                        <th>Id</th>
                        <td><span runat="server" id="spnUserid"></span></td>
                        <th>Password</th>
                        <td>
                            <input type="text" runat="server" id="password" />
                        </td>
                    </tr>
                    <tr>
                        <th>First Name</th>
                        <td><input type="text" runat="server" id="fname" /></td>
                        <th>Last Name</th>
                        <td><input type="text" runat="server" id="lname" /></td>
                    </tr>
                    <tr>
                        <th>Date of Birth</th>
                        <td><input type="date" id="dob" runat="server"></td>
                        <th>GPA</th>
                        <td><input type="number" id="gpa" runat="server" min="0" max="5" step=".01"></td>
                    </tr>
                    <tr>
                        <th>Email</th>
                        <td><input type="email" id="email" runat="server"></td>
                        <th>Phone Number</th>
                        <td><input type="tel" id="tel" runat="server"></td>
                    </tr>
                    <tr>
                        <th>Address</th>
                        <td><input type="text" id="address" runat="server"></td>
                        <th>Recieve mailing?</th>
                        <td><input type="checkbox" runat="server" id="spam"></td>
                    </tr>
                    <tr>
                        <th>Is Admin?</th>
                        <td colspan="3"><input type="checkbox" runat="server" id="isAdmin"></td>
                    </tr>
                    <tr>
                        <th id="delUserCaption" runat="server">Delete User</th>
                        <td><input type="checkbox" id="userDel" runat="server"></td>
                        <td colspan="2"><input type="submit" value="Submit" name="submit" runat="server" ></td>
                    </tr>
                </table>
            </div>
        </form>
    </asp:Content>