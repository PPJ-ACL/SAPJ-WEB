using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaGUI
{
    public partial class ConfirmacionClave : System.Web.UI.Page
    {
        
        Negocio aux = new Negocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCodVerificacion.Visible = false;
            tbCodigoVerif.Visible = false;
            BtnConfirmar.Visible = false;
            BtnEnviarCorreo.Enabled = true;
            tbCorreo.ReadOnly = false;

        }

        protected void BtnEnviarCorreo_Click(object sender, EventArgs e)
        {
            lblValida.Text = aux.generarCod();
            string correo = tbCorreo.Text;  
            string body = @"<div style=background-color:#E02957;height:100px;width:100%></div><!-- Poppins SemiBlod --><div style=font-size:32px;font-family:Poppins,sans-serif;font-weight:600;color:#FFFFFF;background-color:#E02957;><style>@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@400;600&display=swap');</style>ACL<br></div><div style=font-size:20px;font-family:Poppins,sans-serif;color:#000000>El Siguiente usuario:<br>" + correo + "<br>Su código de verificación fue generado exitosamente:<br>"+lblValida.Text+"<div style= font-size:18px;font-family:Poppins,sans-serif;background-color:#1F2937;color:#FFFFFF;>Estimado usuario este mensaje fue generado de forma automatica pero su error será tomado en cuenta para futuras correcciones dentro de SAPJ<br>Mas informacion en nuestras redes sociales.<br></div> <div>	<a href ='https://www.facebook.com/aclconsultores/'> <font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Facebook    </font></a><a href ='https://www.instagram.com/acl.consultores/'><font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Instragram    </font></a><a href ='https://www.linkedin.com/company/acltecnologia/mycompany/'><font style= font-size:18px;font-family:Poppins,sans-serif;font-weight:100;color:#6B7280>Linkedin    </font></a></div></div>";
            try
            {
                aux.enviarMail(correo, "Recuperación de Contraseña", body);
                lblCodVerificacion.Visible = true;
                tbCodigoVerif.Visible = true;
                BtnConfirmar.Visible = true;
                BtnEnviarCorreo.Enabled = false;
                tbCorreo.ReadOnly = true;
                

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: "+ex.Message+"')</script>");
                throw;
            }
        }

        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if(tbCodigoVerif.Text == lblValida.Text)
            {
                Response.Redirect("OlvidoClave.aspx?Correo="+tbCorreo.Text);
                Response.Write("<script>alert('Se confirmó su cuenta')</script>");
                Server.Transfer("OlvidoClave.aspx");
            }
            else if(tbCodigoVerif.Text != lblValida.Text)
            {
                Response.Write("<script>alert('Código Invalido')</script>");

            }
        }
    }
}