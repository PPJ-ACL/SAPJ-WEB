using CapaConexion;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data.SqlClient;
using Google.Apis.Drive.v3;
using System.Net.Mail;
using System.Net;

namespace CapaNegocio
{
    public class Negocio
    {
        private ConexionSQL conec;

        static string[] Scopes = { DriveService.Scope.Drive };
        public ConexionSQL Conec { get => conec; set => conec = value; }

        //Cadena Francisco Veas
        //String ConnectString = @"Data Source=DESKTOP-8DLFPLG\SQLEXPRESS;Initial Catalog=SAPJDEV ;Integrated Security=True";
        //Cadena Patricio Gonzalez
        //String ConnectString = @"Data Source=MARUCHANBOOK;Initial Catalog=SAPJDEV ;Integrated Security=True";
        //Cadena Luis Cordova
        String ConnectString = @"Data Source=LUCHITO-PC\SQLEXPRESS;Initial Catalog=SAPJDEV ;Integrated Security=True";
        public void configConex()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreTabla = "Profesional";
            this.Conec.NombreBaseDatos = "SAPJDEV";
            //Cadena Francisco Veas
            this.Conec.CadenaConexion = ConnectString;
            //Cadena Patricio Gonzalez
            this.Conec.CadenaConexion = ConnectString;
            //Cadena Luis Cordova
            this.Conec.CadenaConexion = ConnectString;
        }
        public int Login(String correo, String cont)
        {
            string cadenaSQL = "SELECT COUNT(Correo) AS Usuario_Correo,COUNT(Contrasenna) AS CONTRASENNA FROM VistaLoginWeb WHERE VistaLoginWeb.Correo = '" + correo + "' AND VistaLoginWeb.contrasenna = '" + cont + "' GROUP BY Contrasenna;";
            SqlConnection con = new SqlConnection(ConnectString);
            SqlCommand cmd = new SqlCommand(cadenaSQL, con);
            SqlDataReader mReader;
            int valUsu = 0;
            try
            {
                con.Open();
                mReader = cmd.ExecuteReader();
                while (mReader.Read())
                {
                    int usuEncontrado = mReader.GetInt32(0);
                    if (usuEncontrado == 1)
                    {
                        valUsu = usuEncontrado;
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            return valUsu;
        }

        public string enviarMail(string to, string asunto, string body)
        {
            //Msg Error
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde.";
            //Correo Origen
            string from = "SAPJACL@gmail.com";
            //Alias
            string displayName = "SAPJ ACL";
            try
            {
                //Instancia
                MailMessage mail = new MailMessage();
                //Desde donde sale el correo
                mail.From = new MailAddress(from, displayName);
                //Destinatario
                mail.To.Add(to);
                //Copia Segundo Destinatario
                mail.CC.Add("fveas@acl.cl");
                mail.CC.Add("lcordova@acl.cl");
                //Asunto
                mail.Subject = asunto;
                //Cuerpo
                mail.Body = body;
                //Validacion Cuerpo HTML
                mail.IsBodyHtml = true;

                //Server a usar
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Aquí debes sustituir tu servidor SMTP y el puerto
                //Credenciales
                client.Credentials = new NetworkCredential(from, "SAPJ2021.");
                //Cifrado SSL
                client.EnableSsl = true;//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false

                //Enviar 
                client.Send(mail);
                //Msg Confirma
                msge = "¡Correo enviado exitosamente! Pronto te contactaremos.";

            }
            catch (Exception ex)
            {
                msge = ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return msge;
        }

        public void updateClave(string correo, string contra)
        {
            string updateSql = "UPDATE VistaLoginWeb SET Contrasenna = '"+contra+"' WHERE Correo = '"+correo+"';";
            SqlConnection con = new SqlConnection(ConnectString);
            SqlCommand cmd = new SqlCommand(updateSql, con);
            SqlDataReader mReader;
            try
            {
                con.Open();
                mReader = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
