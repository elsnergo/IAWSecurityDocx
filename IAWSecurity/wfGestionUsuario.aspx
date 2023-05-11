<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfGestionUsuario.aspx.cs" Inherits="IAWSecurity.wfGestionUsuario" %>

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
                                    <%--<asp:GridView ID="gvUsuarios" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="idUser" OnRowCommand="gvUsuarios_RowCommand" CssClass="table">--%>
                                    <asp:GridView ID="gvUsuarios" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="idUser" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged" OnRowCommand="gvUsuarios_RowCommand" CssClass="table">
                                        <Columns>
                                            <asp:BoundField DataField="idUser" HeaderText="idUser" InsertVisible="False" ReadOnly="True" SortExpression="idUser" />
                                            <asp:BoundField DataField="userName" HeaderText="userName" SortExpression="userName" />
                                            <asp:BoundField DataField="nombres" HeaderText="nombres" SortExpression="nombres" />
                                            <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
                                            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                            <%-- <asp:ButtonField runat="server" Text="Ver" CommandName="Ver" />
                                                 <asp:ButtonField runat="server" Text="Editar" CommandName="Editar" />
                                                 <asp:ButtonField runat="server" Text="Eliminar" CommandName="Eliminar" />--%>
                                            <asp:TemplateField HeaderText="Acciones" >
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="btnView" runat="server" Text="Ver" CssClass="btn-info" CommandName="Select" CommandArgument='<%#Bind("idUser") %>'><img src="icons/binoculars_icon_32.png" title="Ver"/></asp:LinkButton>
                                                    <asp:LinkButton ID="btnEditar" runat="server" Text="Editar" CssClass="btn-info" CommandName="Edit" CommandArgument='<%#Bind("idUser") %>'><img src="icons/editing_icon_32.png" title="Editar"/></asp:LinkButton>
                                                    <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn-info" CommandName="Eliminar" CommandArgument='<%#Bind("idUser") %>'><img src="icons/delete_icon_32.png" title="Eliminar"/></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            
                                            
                                            
                                        </Columns>
                                    </asp:GridView>
                                    <asp:Label ID="lblidUser" runat="server"></asp:Label>
                                    <asp:Label ID="lblidUser2" runat="server"></asp:Label>
                                </div>
                            </div>

                        </div>

                    </div>

                </section>
            </div>
        </section>
    </section>




</asp:Content>
