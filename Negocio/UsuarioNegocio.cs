using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Entidades;
using Datos;
using System.Security.Cryptography;

namespace Negocio
{
    public class UsuarioNegocio
    {
        Usuario user = new Usuario();
        AES aes = new AES();
        AesDatos aesDatos = new AesDatos();
        UsuarioDatos usuarioDatos = new UsuarioDatos();

        public bool InsertarUsuarioNegocio(Usuario us)
        {
            int idUsuarioGuardado = 0;
            bool guardado = false;
            string privateKey = "";
            string myIv = "";
            string pwdEncrypted = "";
            try
            {
                //Encryptamos la contraseña del usuario
                using (Aes myAes = Aes.Create())
                { 
                    privateKey = aesDatos.randomAlphaNumeric(32);
                    myIv = Convert.ToBase64String(myAes.IV);
                    pwdEncrypted = aesDatos.Encrypt_Aes(us.pwd, privateKey, myIv);
                    
                    Console.WriteLine($"Encrypted: '{pwdEncrypted}'");
                    Console.WriteLine($"Private Key: '{privateKey}'");
                    Console.WriteLine($"My IV: '{myIv}'");
                    Console.WriteLine($"pwdOriginal: '{us.pwd}'");
                }
                //Asignamos al objeto la contraseña encriptada
                us.pwd = pwdEncrypted;
                idUsuarioGuardado = usuarioDatos.InsertarUsuarioDatos(us);
                //Construimos el objeto AES con los datos de seguridad del usuario
                aes.idUsuario = idUsuarioGuardado;
                aes.token = privateKey;
                aes.iv = myIv;
                guardado = usuarioDatos.InsertarAES(aes);

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
            }
            return guardado;
        }
        /*
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
        */
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

        /*
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
        */
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

        public bool validarCredencialesNeg(string usuario, string pwd, int rol)
        {
            bool entrar = false;
            try
            {
                entrar = usuarioDatos.validarCredenciales(usuario, pwd, rol);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error en la capa de negocio: " + e.Message.ToString());
                Debug.WriteLine(e.StackTrace.ToString());
            }
            return entrar;
        }

    }
}
