<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Presentation.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Test</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-sm-6">
                <div class="text-center">
                    <h4>Authentication</h4>
                </div>
                <form id="form1" runat="server">
                    <div>
                        <div class="form-group">
                            <asp:Label Text="Usuario" runat="server" /> 
                            <input class="form-control" type="email" name="txtEmail" value="" />
                        </div>
                       
                        <div class="form-group">
                            <asp:Label Text="Contraseña" runat="server" />
                            <input class="form-control" type="password" name="txtPassword" value="" />
                        </div>
                        <div class="form-group text-center">
                            <br />
                            <asp:Button Text="Validar" CssClass=" btn btn-sm btn-primary" runat="server" ID="btnValidate" OnClick="btnValidate_Click" />
                        </div>
                    </div>
                </form>
                <div class="text-center">
                    <br />
                    <asp:HyperLink NavigateUrl="googleAuthenticator.aspx" Text="Link google authenticator" runat="server" />
                </div>
            </div>
        </div>
    </div>
</body>
</html>
