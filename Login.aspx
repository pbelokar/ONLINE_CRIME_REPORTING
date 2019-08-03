﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CriminalRecordManagement.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>

  <meta charset="UTF-8"/>

    <title>Log-in</title>
    <link rel='stylesheet' href='http://codepen.io/assets/libs/fullpage/jquery-ui.css'/>
    <link href="Scripts/style.css" rel="stylesheet" />
</head>

<body>
    <div class="login-card">
        <h1>Log-in</h1>
        <form runat ="server">
            <asp:Label ID="lblerror" runat="server" Font-Size="Small" ForeColor="Red"></asp:Label>
            <br/>
            <asp:TextBox ID="txtusername" runat="server" placeholder="Username"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="login" class="login login-submit" OnClick="btnSubmit_Click"/>
        
        </form>

        <div class="login-help">
            <a href="#">Register</a> • <a href="#">Forgot Password</a>
        </div>
    </div>
</body>
</html>