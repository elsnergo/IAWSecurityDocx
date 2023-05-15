<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfLogin.aspx.cs" Inherits="IAWSecurity.wfLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
</head>
<body>
    <section id="main-content">
        <section class="panel">
            <header class="panel-heading d-flex justify-content-center">
                <h3>
                    Acceso de Usuarios
                </h3>
            </header>
            <hr />
            <form id="Login" runat="server">
                 <asp:ScriptManager runat="server">
                    <Scripts>
                        <%--Para obtener más información sobre la unión de scripts en ScriptManager, consulte https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                        <%--Scripts de marco--%>
                        <asp:ScriptReference Name="MsAjaxBundle" />
                        <asp:ScriptReference Name="jquery" />
                        <asp:ScriptReference Name="bootstrap" />
                        <asp:ScriptReference Name="respond" />
                        <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                        <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                        <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                        <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                        <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                        <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                        <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                        <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                        <asp:ScriptReference Name="WebFormsBundle" />
                        <%--Scripts del sitio--%>
                    </Scripts>
                </asp:ScriptManager>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-3 mx-auto">
                            <div class="text-center">
                                <div class="form-group row">
                                    <div class="col-md-4">
                                        <asp:Label runat="server">Usuario: </asp:Label>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtUsuario" name="txtUsuario" ValidationGroup="User" runat="server" Enabled="true" CssClass="form-control" placeholder="Ejemplo: elsnergo" title="Ingrese su nombre de usuario"></asp:TextBox>
                                    </div>
                                    <asp:RequiredFieldValidator ID="rfvUsuario" 
                                        ControlToValidate="txtUsuario" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group row">
                                    <div class="col-md-4">
                                        <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtClave" name="txtClave" ValidationGroup="User" runat="server" Enabled="true" TextMode="Password" CssClass="form-control input-sm" placeholder="Incluya: [A-Z][a-z][0-9] y [Caracteres especiales]" title="Ingrese su Contraseña"></asp:TextBox>
                                    </div> 
                                    <asp:RequiredFieldValidator ID="rfvClave" 
                                        ControlToValidate="txtClave" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group row">
                                    <div class="col-md-4">
                                        <asp:Label ID="Label3" runat="server" Text="Rol:"></asp:Label>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:DropDownList ID="ddlRol" name="ddlRol" ValidationGroup="User" runat="server" Enabled="true" CssClass="form-control input-sm"></asp:DropDownList>
                                    </div> 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                                        ControlToValidate="txtClave" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                                <div class="form-group row">
                                    <div class="col-md-12">
                                        <asp:Button ID="btnEntrar" runat="server" Text="Entrar" CssClass="btn btn-primary btn-sm col" ValidationGroup="User" OnClick="btnEntrar_Click"/>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-md-12">    
                                        <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-danger btn-sm col" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <hr />
                <div class="d-flex justify-content-center">
                    <footer>
                        <p>&copy; <%: DateTime.Now.Year %> - By Elsner González</p>
                    </footer>
                </div>
           </form>
        </section>
    </section>
</body>
</html>
