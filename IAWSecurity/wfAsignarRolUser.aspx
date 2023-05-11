<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfAsignarRolUser.aspx.cs" Inherits="IAWSecurity.wfAsignarRolUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section id="main-content">
        <section id="wrapper">
            <div class="col-lg-12">
                <section class="panel">
                    <header class="panel-heading">
                        <div class="col-md4 col-md-offset-4">
                            <h1>Gestión de Usuarios
                            </h1>
                        </div>
                    </header>

                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md4 col-md-offset-1">
                                <div class="form-group">





                                    <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                                    
                                    <asp:DropDownList ID="ddlUsuario" runat="server">
                                    </asp:DropDownList>





                                </div>
                            </div>
                        </div>
                    </div>
                </section>
            </div>
        </section>
    </section>



</asp:Content>
