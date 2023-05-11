using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;
using System.Diagnostics;

namespace IAWSecurity
{
    public partial class wfEditarUsuario : System.Web.UI.Page
    {
        Usuario usuario = new Usuario();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarDatos();
            }
        }


        protected void cargarDatos()
        {
            usuario = (Usuario) Session["Usuario"];
            this.txtUsuario.Text = usuario.userName;
            this.txtNombres.Text = usuario.nombres;
            this.txtApellidos.Text = usuario.apellidos;
            this.txtEmail.Text = usuario.email;
            this.txtEmail2.Text = usuario.email;
            this.txtClave.Text = usuario.pwd;
            this.txtClave2.Text = usuario.pwd;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            bool msj = false;
            Usuario u = (Usuario)Session["Usuario"];

            usuario.idUser = u.idUser;
            usuario.userName = this.txtUsuario.Text.Trim();
            usuario.nombres = this.txtNombres.Text.Trim().ToUpper();
            usuario.apellidos = this.txtApellidos.Text.Trim().ToUpper();
            usuario.pwd = this.txtClave.Text.Trim();
            usuario.email = this.txtEmail.Text.Trim();
            usuario.estado = 2;

            msj = usuarioNegocio.editarUsuarioNegocio(usuario);
            Response.Redirect("~/wfGestionUsuario.aspx");
        }
    }
 }