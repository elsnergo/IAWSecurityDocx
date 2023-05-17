using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Datos
{
    public class CorreoElectronicoDatos
    {
        public bool EnviarCorreoElectronico(string correoRecibe, string codVerificacion)
        {
            bool enviado = false;
            SmtpClient smtp = null;
            MailMessage email = null;
            //Enlace de verificación de correo
            String linkHR = "http://localhost:65523/wfLogin.aspx";
            try
            {
                using (smtp = new SmtpClient())
                {
                    using (email = new MailMessage())
                    {
                        smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587; //465
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential("egonzalezo1987@gmail.com", "bwzqbbldpmlgehdb");

                        //Cuerpo del correo  
                        string myMsg = "<strong>PROCESO DE VERIFICACION DEL CORREO INSTITUCIONAL UCA</strong><br><br>";
                        myMsg += "Estimado usuario, usted ha solicitado el ingreso al Sistema ...,";
                        myMsg += "a continuaci&oacute;n se detallan los datos enviados: <br><br>";
                        myMsg += "<strong><u> DATOS DEL USUARIO/ESTUDIANTE </u></strong> <br><br>";
                        myMsg += "<strong>USUARIO: </strong> " + correoRecibe + "<br>";
                        myMsg += "<strong>Correo electr&oacute;nico: </strong> " + correoRecibe + "<br>";
                        myMsg += "Enlace de verificaci&oacute;n: " + linkHR + "?codverif=" + codVerificacion + "<br>";
                        myMsg += "Aseg&uacute;rate de hacer clic en el enlace de verificaci&oacute;n que has recibido para que podamos activar tu cuenta, en caso de no haber solicitado una cuenta, por favor hacer caso omiso al presente correo.";
                        myMsg += "<br>----------------------------------------------------------<br>";
                        myMsg += "ARMANDO J. LOPEZ L.<br>";
                        myMsg += "Celular: +505 8888-8888 <br>";
                        myMsg += "Coordinador de ISI<br>";
                        myMsg += "Universidad Centroamericana";


                        email = new MailMessage();
                        email.To.Add(new MailAddress(correoRecibe));
                        email.From = new MailAddress("egonzalezo1987@gmail.com", "Universidad Centroamericana - UCA");
                        email.Subject = "Asunto Prueba";
                        email.Priority = System.Net.Mail.MailPriority.Normal;
                        email.Body = myMsg;
                        email.IsBodyHtml = true;
                        smtp.Send(email);
                        enviado = true;
                    }
                }
                return enviado;
            }
            catch (Exception exception)
            {
                //TODO: Manejar excepciones
                throw exception;
            }
        }

        public void EnviarCorreoElectronicoAdjunto(string correoRecibe, string cuerpoCorreo, System.IO.MemoryStream pdf, string nombrePdf, int idTipoPrueba)
        {
            SmtpClient smtp = null;
            MailMessage email = null;
            try
            {
                using (smtp = new SmtpClient())
                {
                    using (email = new MailMessage())
                    {
                        smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587; //465
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential("Correo desde donde se envia", "Contraseña");


                        email = new MailMessage();
                        email.To.Add(correoRecibe);
                        email.From = new MailAddress("Correo desde donde se envia", "Universidad Centroamericana - UCA");
                        email.Subject = "Asunto";
                        email.Priority = System.Net.Mail.MailPriority.Normal;
                        email.Body = cuerpoCorreo;
                        email.IsBodyHtml = true;
                        //adjuntamos pdf creado
                        Attachment apdf = new Attachment(pdf, nombrePdf);
                        email.Attachments.Add(apdf);
                        smtp.Send(email);
                    }
                }
                return;
            }
            catch (Exception exception)
            {
                //TODO: Manejar excepciones
                throw exception;
            }
        }
    }
    
}
