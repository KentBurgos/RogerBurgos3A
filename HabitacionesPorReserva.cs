using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Clases
{
    public class HabitacionesPorReserva
    {

        private Habitacion habitacion;

        public Habitacion Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }

        private List<ServiciosExtra> servicios;

        public List<ServiciosExtra> Servicios

        {
              
            set { servicios = value; }
        }



    }
}
