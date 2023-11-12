using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Complejo
    {
        private List<Cancha> canchas;
        private List<Administrador> administradores;

        public Complejo() 
        {
            this.canchas = new List<Cancha>();
            this.administradores = new List<Administrador>();
        }
    }
}
