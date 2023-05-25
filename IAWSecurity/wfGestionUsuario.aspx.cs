using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IAWSecurity
{
    public partial class wfGestionUsuario : System.Web.UI.Page
    {
        Usuario us = new Usuario();
        UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            /* if (!IsPostBack)
                 this.ObtenerListado();*/

            CargarDatosGridView();
        }

        public void verRptListUsuario()
        {
            Response.Redirect("~/wfRptListUsuarios.aspx",false);
        }

        /*
        private void ObtenerListado()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            var respuesta = new UsuarioNegocio().ListarUsuarioNegocioSami(ref listaUsuario);
            if(!respuesta)
            {
                //DEBERA PRESENTAR MENSAJE AL USUARIO QUE NO EXISTEN REGISTRO O QUE SUCEDIO UN ERROR
                return;
            }

            this.CargarDatosGridView(listaUsuario);
        }

        private void CargarDatosGridView(List<Usuario> listaUsuario)
        {
            try
            {
                gvUsuarios.DataSource = listaUsuario;
                gvUsuarios.DataBind();
            }
            catch (Exception)
            {
            }
        }
        */


        private void CargarDatosGridView()
        {
            gvUsuarios.DataSource = usuarioNegocio.ListarUsuarioNegocio();
            gvUsuarios.DataBind();
        }


        protected void gvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int id = int.Parse(e.CommandArgument.ToString());
                //int id = int.Parse(gvUsuarios.DataKeys[index].Value.ToString());
                Debug.WriteLine("id by commandArgument: " + id.ToString());
                //Debug.WriteLine("id DataKeys: " + id.ToString());
                //this.lblidUser.Text = id.ToString();
                us = usuarioNegocio.obtenerUsuarioNegocioByID(id);
                Session["Usuario"] = us;
                Response.Redirect("~/wfEditarUsuario.aspx");

            }
        }

         protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
         {
            /*
             GridViewRow row = this.gvUsuarios.SelectedRow;
             int id = Convert.ToInt32(gvUsuarios.DataKeys[row.RowIndex].Value);
             Debug.WriteLine("id DataKeys: " + id.ToString());
             this.lblidUser2.Text = id.ToString();
            */
         }

        protected void gvUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView gv = (GridView)sender;
            gv.PageIndex = e.NewPageIndex;
            CargarDatosGridView();
        }


        /*protected void btnEditar_Click(object sender, EventArgs e)
        {
            
            string id;
            string nombre, apellido, nombre_usuario, clave;
            Button btnConsultar = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectedRow.Cells[1].Text;
            nombre = selectedRow.Cells[2].Text;
            apellido = selectedRow.Cells[3].Text;
            nombre_usuario = selectedRow.Cells[4].Text;
            clave = selectedRow.Cells[5].Text;
            



            //Mandando datos a los campos
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectedRow.Cells[1].Text;
            Debug.WriteLine("id selectedRow: "+ id);
            Session["idUsuario"] = id;

            Response.Redirect("wfEditarUsuario.aspx"); 
        }
        */


    }
}