using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Diagnostics;

namespace Negocio
{
    public class RolNegocio
    {
        RolDatos rolDt = new RolDatos();

        public List<Rol> llenarComboRolNeg()
        {
            List<Rol> listaRol = new List<Rol>();
            try
            {
                listaRol = rolDt.LlenarComboRol();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
            }
            return listaRol;
        }
    }
}
