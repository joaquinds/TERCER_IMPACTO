using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.Registrar_Agenda_Medico
{
    class FranjaHoraria
    {
        public DateTime desde;
        public DateTime hasta;

        public FranjaHoraria(DateTime d, DateTime h)
        {
            desde = d;
            hasta = h;
        }
    }
}
