using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using Entidades;
using System.Diagnostics;
using System.Data.Entity.Migrations;

namespace Datos
{
    public class UsuarioDatos
    {
        seguridadDBEntities modelo = new seguridadDBEntities();
        Usuario user = new Usuario();
        AES aes = new AES();
        AesDatos aesDt = new AesDatos();
        
        public int InsertarUsuarioDatos(Usuario user)
        {
            int idUsuarioGuardado = 0;
            modelo.Usuario.Add(user);
            modelo.SaveChanges();
            idUsuarioGuardado = user.idUser;
            Console.WriteLine($"idUsuarioGuardado: '{idUsuarioGuardado}'");
            return idUsuarioGuardado;
        }

        public bool InsertarAES(AES aes)
        {
            bool guardado = false;
            modelo.AES.Add(aes);
            modelo.SaveChanges();
            guardado = true;
            return guardado;
        }



        /*
        public List<Usuario> ListarUsuarioDatos()
        {
            List<Usuario> listUsuario = new List<Usuario>();
            try
            {
                listUsuario = modelo.Usuario.ToList();   
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de datos: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
            }

            return listUsuario;
        }
        */

        /*
            public List<Usuario> ObtenerListaUsuarioDatos()
            {
                using (var contexto = new seguridadDBEntities())
                {
                    return contexto.Usuario.ToList();
                }            
            }
        */

        public List<Usuario> ListarUsuarioDatos()
        {
            List<Usuario> listUsuario = new List<Usuario>();
            listUsuario = modelo.Usuario.ToList();
            return listUsuario;
        }

        public Usuario obtenerUsuarioByID(int idU)
        {
            //Usuario us = new Usuario();
            return modelo.Usuario.Find(idU);
            //return us;
        }

        public bool editarUsuarioDatos(Usuario user)
        {
            bool editado = false;
            Usuario us = modelo.Usuario.Where(f => f.idUser == user.idUser).FirstOrDefault();
            //Usuario us = modelo.Usuario.Find(user.idUser);
            us.userName = user.userName;
            us.nombres = user.nombres;
            us.apellidos = user.apellidos;
            us.email = user.email;
            us.pwd = user.pwd;
            us.estado = user.estado;
            modelo.Usuario.AddOrUpdate(us);
            modelo.SaveChanges();
            editado = true;
            return editado;
        }

        public List<Usuario> LlenarComboUsuarios()
        {
            List<Usuario> listUsuario = new List<Usuario>();
            listUsuario = modelo.Usuario.ToList();
            return listUsuario;
        }

        public bool validarCredenciales(string usuario, string pwd, int rol)
        {
            bool entrar = false;
            string pwdDecrypt = "";
            int rolSelected = rol;
            Debug.WriteLine("rolSelected: " + rol);

            user = modelo.Usuario.Where(u => u.userName.Equals(usuario)).FirstOrDefault();
            aes = modelo.AES.Where(a => a.idUsuario == user.idUser).FirstOrDefault();

            pwdDecrypt = aesDt.Decrypt_Aes(user.pwd, aes.token, aes.iv);

            if(usuario.Equals(user.userName) && pwd.Equals(pwdDecrypt))
            {
                entrar = true;
            }
            else
            {
                entrar = false;
            }

            return entrar;
        }


    }
}