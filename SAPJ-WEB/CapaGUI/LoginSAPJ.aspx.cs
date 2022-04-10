using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CapaGUI
{
    public partial class LoginSAPJ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = tbUsuario.Text;
            String pass = tbPassword.Text;
            Negocio aux = new Negocio();
            if (aux.Login(usuario, pass) == 1)
            {
                Server.Transfer("PaginaCentral.aspx");
                lblError.Text = "";
            }
            else
            {
                vaciarTxt();
                lblError.Text = "Error: Usuario No Encontrado";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }

        public void vaciarTxt()
        {
            tbUsuario.Text = "";
            tbPassword.Text = "";
        }
    }
}