using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        private DateTime fechaYHora;
        private Cancha cancha;
        private Arrendatario? arrendatario;

        public Arrendatario? Arrendatario { get => this.arrendatario; set => this.arrendatario = value; }

        public Turno(DateTime fechaYHora, Cancha cancha)
        {
            this.fechaYHora = fechaYHora;
            this.cancha = cancha;
            this.arrendatario = null;
        }

        public static bool operator == (Turno t1, Turno t2)
        {
            return t1.fechaYHora == t2.fechaYHora && t1.cancha == t2.cancha;
        }

        public static bool operator != (Turno t1, Turno t2) 
        { 
            return !(t1 == t2); 
        }
    }
}
