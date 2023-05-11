using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Entidades;
using Datos;

namespace Negocio
{
    public class UsuarioNegocio
    {
        Usuario user = new Usuario();
        UsuarioDatos usuarioDatos = new UsuarioDatos();

        public bool InsertarUsuarioNegocio(Usuario us)
        {
            bool ngUsuarioGuardado = false;
            try
            {
                ngUsuarioGuardado = usuarioDatos.InsertarUsuarioDatos(us);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
            }
            return ngUsuarioGuardado;
        }

        public string InsertarUsuarioNegocioSami(Usuario us)
        {
            string mensaje = "El registro se guardo de manera correcta";
            try
            {
                var ngUsuarioGuardado = usuarioDatos.InsertarUsuarioDatos(us);
                if (!ngUsuarioGuardado)
                    mensaje = "El registro del usuario no pudo ser completado";
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
                    mensaje = "El registro del usuario no pudo ser completado";
            }
            return mensaje;
        }

        public List<Usuario> ListarUsuarioNegocio()
        {
            List<Usuario> listUsuarioNegocio = new List<Usuario>();
            try
            {
                listUsuarioNegocio = usuarioDatos.ListarUsuarioDatos();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
            }
            return listUsuarioNegocio;
        }

        public bool ListarUsuarioNegocioSami(ref List<Usuario> listaUsuario)
        {
            bool respuesta = true;
            try
            {
                listaUsuario = usuarioDatos.ListarUsuarioDatos();
                if (!listaUsuario.Any())
                    respuesta = false;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
                respuesta = false;
            }
            return respuesta;
        }

        public Usuario obtenerUsuarioNegocioByID(int id)
        {
            try
            {
                user = usuarioDatos.obtenerUsuarioByID(id);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
            }
            return user;
        }

        public bool editarUsuarioNegocio(Usuario us)
        {
            bool ngUsuarioEditado = false;
            try
            {
                ngUsuarioEditado = usuarioDatos.editarUsuarioDatos(us);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
            }
            return ngUsuarioEditado;
        }
    }
}
