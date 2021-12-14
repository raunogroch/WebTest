<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Presentation.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Main</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <h3>Home page</h3>
    <form runat="server">
        <asp:Button CssClass="btn btn-danger" Text="SignOut" ID="btnLogOut"  runat="server" OnClick="btnLogOut_Click" />
    </form>
    <div class="text-center">
        <br />
        <asp:HyperLink NavigateUrl="googleAuthenticator.aspx" Text="Link google authenticator" runat="server" />
    </div>
</body>
</html>
