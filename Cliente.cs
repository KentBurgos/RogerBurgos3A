using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Clases
{
    public class Cliente
    {
        private String identificacion;

        public String Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private Reserva reserva;

        public Reserva Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }





    }
}
