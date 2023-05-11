using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IAWSecurity
{
    public partial class wfAsignarRolUser : System.Web.UI.Page
    {
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private void CargarDDL()
        {
            ddlUsuario.DataSource = usuarioNegocio.ListarUsuarioNegocio();
            ddlUsuario.DataBind();
        }
    }
}