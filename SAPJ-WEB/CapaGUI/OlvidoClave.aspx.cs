using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaGUI
{
    public partial class OlvidoClave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string correo = Request.QueryString["Correo"];
            tbCorreo.Text = correo;
            if (tbCorreo.Text.Length>0)
            {
              tbCorreo.ReadOnly = true;
            }
            else
            {
                tbCorreo.ReadOnly = false;
            }
            
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            if(tbContrasennaNueva.Text == tbConfirmaContrasenna.Text)
            {
                string correo = tbCorreo.Text;
                string contra = tbContrasennaNueva.Text;
                string body = @"<div style=background-color:#E02957;height:100px;width:100%></div><!-- Poppins SemiBlod --><div style=font-size:32px;font-family:Poppins,sans-serif;font-weight:600;color:#FFFFFF;background-color:#E02957;><style>@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;600&display=swap');</style>ACL<br></div><div style=font-size:20px;font-family:Poppins,sans-serif;color:#000000>El Siguiente usuario:<br>" + correo + "<br>Solicitó un cambio de contraseña el cual fue realizado con exito<div style= font-size:18px;font-family:Poppins,sans-serif;background-color:#1F2937;color:#FFFFFF;>Estimado usuario este mensaje fue generado de forma automatica pero su error será tomado en cuenta para futuras correcciones dentro de SAPJ<br>Mas informacion en nuestras redes sociales.<br></div> <div>	<a href ='https://www.facebook.com/aclconsultores/'> <font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Facebook    </font></a><a href ='https://www.instagram.com/acl.consultores/'><font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Instragram    </font></a><a href ='https://www.linkedin.com/company/acltecnologia/mycompany/'><font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Linkedin    </font></a></div></div>";
                Negocio aux = new Negocio();
                try
                {
                    aux.updateClave(correo, contra);
                    aux.enviarMail(correo, "Recuperación de Contraseña", body);
                    Response.Write("<script>alert('Se cambió su clave con exito')</script>");
                    Server.Transfer("LoginSAPJ.aspx");
                    vaciarCampos();
                }
                catch (Exception ex)
                {
                    lblError.Text = "Error:" + ex.Message;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    vaciarCampos();
                }
            }
            else
            {
                Response.Write("<script>alert('Las contraseñas no coinciden')</script>");
                vaciarCampos();
            }
            
        }

        public void vaciarCampos()
        {
            tbConfirmaContrasenna.Text = "";
            tbContrasennaNueva.Text = "";
            tbCorreo.Text = "";
        }
    }
}