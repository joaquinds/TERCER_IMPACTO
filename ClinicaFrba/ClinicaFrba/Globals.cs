using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba
{
    static class Globals
    {
        public static string fecha_sistema = ConfigurationManager.AppSettings["fecha_sistema"];
        public static decimal id_usuario;
        public static decimal id_rol;
        public static string nombre_rol;
    }
}
