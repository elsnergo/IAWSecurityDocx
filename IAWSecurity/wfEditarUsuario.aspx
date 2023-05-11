<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfEditarUsuario.aspx.cs" Inherits="IAWSecurity.wfEditarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section id="main-content">
        <section id="wrapper">
            <div class="col-lg-12">
                <section class="panel">
                    <header class="panel-heading">
                        <div class="col-md4 col-md-offset-4">
                            <h1>
                                Edición: Datos del Usuario
                            </h1>
                        </div>
                    </header>

                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md4 col-md-offset-3">
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                                    <asp:TextBox ID="txtUsuario" name="txtUsuario" ValidationGroup="User" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Ejemplo: elsnergo" title="Ingrese su nombre de usuario"></asp:TextBox>
                              
                                    <asp:RequiredFieldValidator ID="rfvUsuario" 
                                        ControlToValidate="txtUsuario" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md4 col-md-offset-2">
                                <div class="form-group">
                                    <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
                                    <asp:TextBox ID="txtClave" name="txtClave" ValidationGroup="User" runat="server" Enabled="true" TextMode="Password" CssClass="form-control input-sm" placeholder="Incluya: [A-Z][a-z][0-9] y [Caracteres especiales]" title="Ingrese su Contraseña"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvClave" 
                                        ControlToValidate="txtClave" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="col-md4 col-md-offset-2">
                                <div class="form-group">
                                    <asp:Label ID="Label7" runat="server" Text="Confirmar Contraseña:"></asp:Label>
                                    <asp:TextBox ID="txtClave2" name="txtClave2" ValidationGroup="User" runat="server" Enabled="true" TextMode="Password" CssClass="form-control input-sm" placeholder="Incluya: [A-Z][a-z][0-9] y [Caracteres especiales]" title="Confirme su Contraseña"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvClave2" 
                                        ControlToValidate="txtClave2" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md4 col-md-offset-2">
                                <div class="form-group">
                                    <asp:Label ID="Label3" runat="server" Text="Nombres:"></asp:Label>
                                    <asp:TextBox ID="txtNombres" name="txtNombres" ValidationGroup="User" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Nombres" title="Ingrese su nombre"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvNombres" 
                                        ControlToValidate="txtNombres" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="col-md4 col-md-offset-2">
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" Text="Apellidos:"></asp:Label>
                                    <asp:TextBox ID="txtApellidos" name="txtApellidos" ValidationGroup="User" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Apellidos" title="Ingrese sus apellidos"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvApellidos" 
                                        ControlToValidate="txtApellidos" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md4 col-md-offset-2">
                                <div class="form-group">
                                    <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label>
                                    <asp:TextBox ID="txtEmail" name="txtEmail" ValidationGroup="User" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Ejemplo: elsnergo@doc.uca.edu.ni" title="Ingrese un email válido"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEmail" 
                                        ControlToValidate="txtEmail" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="col-md4 col-md-offset-2">
                                <div class="form-group">
                                    <asp:Label ID="Label6" runat="server" Text="Confirmar Email:"></asp:Label>
                                    <asp:TextBox ID="txtEmail2" name="txtEmail" ValidationGroup="User" runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Ejemplo: elsnergo@doc.uca.edu.ni" title="Ingrese un email válido"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEmail2" 
                                        ControlToValidate="txtEmail2" ValidationGroup="User" runat="server" 
                                        Display="Static" ErrorMessage="Este campo es requerido!" ForeColor="#B50128">
                                    </asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <asp:Button ID="btnEditar" runat="server" Text="Guardar" CssClass="btn btn-primary" ValidationGroup="User" OnClick="btnEditar_Click"/>
                                <asp:Button ID="btnCancel" runat="server" Text="Cancelar" CssClass="btn btn-danger" />
                            </div>
                        </div>
                    </div>
                </section>
            </div>
         </section>
    </section>

</asp:Content>
