<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defualt.aspx.cs" Inherits="WebApplication1.Defualt" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server"> 
        <div>
            <div id="HeaderDiv">
                <p id="HeaderText">ASP.NET WebForms / 1DV406 -> Steg 1 -> Laborationsuppgift1</p>
                <h1>Hur många versaler?</h1>
            </div>

            <div id="GreyDiv">
            </div>

            <div id="InputDiv">
                <asp:TextBox ID="TextBox" runat="server" CssClass="TextField" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div id="ResultDiv">
                <asp:PlaceHolder ID="ResultPlaceHolder" Visible="false" runat="server">
                    <p><asp:Literal ID="ResultLiteral" runat="server">Texten innehåller {0} versaler.</asp:Literal></p>
                </asp:PlaceHolder>
                <asp:Button ID="Button" runat="server" Text="Bestäm antalet versaler" OnClick="SubmitButton_Click" CssClass="Buttons" />
            </div>

        </div>
    </form>
</body>
</html>
 