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
    public partial class wfInsertarUsuario : System.Web.UI.Page
    {
        Usuario usuario = new Usuario();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
        bool guardadoUsuario = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void limpiarCampos()
        {
            this.txtUsuario.Text = "";
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.txtClave.Text = "";
            this.txtClave2.Text = "";
            this.txtEmail.Text = "";
            this.txtEmail2.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            /*
            Usuario usuario = new Usuario()
            {
                userName = this.txtUsuario.Text,
                nombres = this.txtNombres.Text,
                apellidos = this.txtApellidos.Text,
                pwd = this.txtClave.Text,
                email = this.txtEmail.Text,
                estado = 1
            };
            */

            usuario.userName = this.txtUsuario.Text.Trim();
            usuario.nombres = this.txtNombres.Text.Trim().ToUpper();
            usuario.apellidos = this.txtApellidos.Text.Trim().ToUpper();
            usuario.pwd = this.txtClave.Text.Trim();
            usuario.email = this.txtEmail.Text.Trim();
            usuario.estado = 1;
        
            var mensaje = usuarioNegocio.InsertarUsuarioNegocio(usuario);
            //guardadoUsuario = usuarioNegocio.InsertarUsuarioNegocioSami(usuario);
            limpiarCampos();

        }
    }
}