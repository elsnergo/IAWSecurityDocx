using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace IAWSecurity
{
    public partial class wfLogin : System.Web.UI.Page
    {
        RolNegocio rolNeg = new RolNegocio();
        UsuarioNegocio usuarioNeg = new UsuarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenaComboRol();
            }
        }

        protected void llenaComboRol()
        {
            this.ddlRol.DataSource = rolNeg.llenarComboRolNeg();
            this.ddlRol.DataTextField = "rolName";
            this.ddlRol.DataValueField = "idRol";
            this.ddlRol.DataBind();    
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            String user = "";
            String pwd = "";
            int rol = 0;
            bool entrar = false;

            user = this.txtUsuario.Text;
            pwd = this.txtClave.Text;
            rol = Convert.ToInt32(this.ddlRol.SelectedValue);

            entrar = usuarioNeg.validarCredencialesNeg(user, pwd, rol);
            if (entrar)
            {
                Response.Redirect("~/");
            }
            else
            {
                Response.Redirect("~/wfLogin.aspx");
            }



        }
    }
}