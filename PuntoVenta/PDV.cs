using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PuntoVenta
{
    class PDV
    {

        //Tabla de Login
        public Int32 ID_Usuario { get; set; }
        public string Usuarios { get; set; }
        public string Contraseña { get; set; }

        public PDV()
        {

        }

        public PDV(int pID_Usuario, string pUsuarios, string pContraseña)
        {
            this.ID_Usuario = pID_Usuario;
            this.Usuarios = pUsuarios;
            this.Contraseña = pContraseña;
        }
    }
}
