<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>This is a fucking test</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"></script>
    <script src="functions.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <button id="btn1" type="button">Click Me!</button>
        <br /><br />
        Employee ID: <label id="idLBL"></label> 
        <br />
        Employee Name: <label id="nameLBL"></label>
    </div>
    </form>
</body>
</html>

