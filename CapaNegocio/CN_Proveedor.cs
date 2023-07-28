using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }
        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.CUIT == "")
            {
                Mensaje += "Es necesario el CUIT del proveedor\n";
            }
            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesaria la razón social del proveedor\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.CUIT == "")
            {
                Mensaje += "Es necesario el CUIT del proveedor\n";
            }
            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesaria la razón social del proveedor\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }
        }
        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
