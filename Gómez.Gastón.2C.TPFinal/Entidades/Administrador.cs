using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interfaces;

namespace Entidades
{
    public class Administrador : Persona, IAltaBaja
    {
        private bool disponible;

        public bool Disponible { get => this.disponible; set => this.disponible = value; }
        public Administrador(string nombre) : base(nombre)
        {
            this.disponible = true;
        }

        public virtual void DarDeAlta() { }
        public virtual void DarDeBaja() { }
    }
}
