using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Diagnostics;
using System.Data.Entity.Migrations;

namespace Datos
{
    public class RolDatos
    {
        seguridadDBEntities modelo = new seguridadDBEntities();

        public List<Rol> LlenarComboRol()
        {
            return modelo.Rol.ToList();
        }


    }
}
