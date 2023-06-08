using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using Microsoft.Reporting.WebForms;

namespace IAWSecurity
{
    public partial class wfRptListUsuarios : System.Web.UI.Page
    {
        UsuarioNegocio usuarioNeg = new UsuarioNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarRptListUsuario();
            }
        }

        protected void cargarRptListUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            listaUsuario = usuarioNeg.ListarUsuarioNegocio();

            rptListUsuario2.Reset();
            /*rptListUsuario2.LocalReport.ReportEmbeddedResource = "IAWSecurity.Reportes.Report1.rdlc";
            rptListUsuario2.ZoomMode = Microsoft.Reporting.WebForms.ZoomMode.PageWidth;
            rptListUsuario2.LocalReport.Refresh();*/

            ReportDataSource datasource = new ReportDataSource("dsUsuario", listaUsuario);
            //rptListUsuario2.LocalReport.DataSources.Clear();
            rptListUsuario2.LocalReport.DataSources.Add(datasource);
            rptListUsuario2.ZoomMode = Microsoft.Reporting.WebForms.ZoomMode.PageWidth;
            rptListUsuario2.LocalReport.Refresh();
            rptListUsuario2.LocalReport.ReportEmbeddedResource = "IAWSecurity.Reportes.Report1.rdlc";

        }



    }
}