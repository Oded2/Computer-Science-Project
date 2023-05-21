<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Odedprojectpleasework.Login" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="style.css" />
    <title>Log In</title>
</head>
<body>
    <div class="header">
        <table>
            <tr>
                <td><a href="index.aspx">Home</a></td>
                <td class="pageName">Log in</td>
                <td><a href="Sign_Up.aspx">Sign Up</a></td>
            </tr>
        </table>
    </div>
    <div class="parent">
        <div class="main">
            <div class="third">
                <form method="post">
                    <h2>ID</h2>
                    <input type="text" name="id" id="id" maxlength="10">
                    <h2>Password</h2>
                    <input type="password" name="password" id="password" maxlength="20">
                    <h2></h2>
                    <input type="submit" id="submit" name="submit" value="Log In"/>
                </form>

            </div>


        </div>
    </div>
    <div class="box">
    </div>
</body>

</html>