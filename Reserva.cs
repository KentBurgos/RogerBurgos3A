using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Clases
{
    public class Reserva
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private String fecha;

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private HabitacionesPorReserva habitaciones;

        public HabitacionesPorReserva Habitaciones
        {
            get { return habitaciones; }
            set { habitaciones = value; }
        }

        private ServiciosExtra servicios;

        public ServiciosExtra Servicios
        {
            get { return servicios; }
            set { servicios = value; }
        }




        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }






    }
}
