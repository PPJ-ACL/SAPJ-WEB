using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;

namespace CapaNegocio
{
    public class Negocio
    {
        private ConexionSQL conec;

        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void ConexionSQL()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreTabla = "Usuario";
            this.Conec.NombreBaseDatos = "portafolio";
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-398JQJ0\SQLEXPRESS;Initial Catalog=portafolio ;Integrated Security=True"; ;
        }
    }
}
