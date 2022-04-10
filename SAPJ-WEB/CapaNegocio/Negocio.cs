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

namespace CapaNegocio
{
    public class Negocio
    {
        private ConexionSQL conec;

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

        
        
    }
}
