﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;

        protected Persona(string nombre) 
        {
            this.nombre = nombre;
        }
    }
}
