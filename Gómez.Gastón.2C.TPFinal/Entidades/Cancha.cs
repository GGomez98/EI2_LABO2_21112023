using Entidades.Interfaces;
namespace Entidades
{
    public enum eCancha
    {
        Futbol,
        Hockey,
        Rugby,
        Tenis
    }
    public class Cancha : IAltaBaja
    {
        private string nombre;
        private bool habilitada;
        private Administrador? administrador;
        private eCancha tipoCancha;
        private float costoBase;

        public Administrador? Administrador { get => this.administrador; }
        public bool Habilitada { get => this.habilitada; set => this.habilitada = value; }

        public Cancha(eCancha tipoCancha) 
        {
            this.tipoCancha = tipoCancha;
            this.habilitada = true;
            this.administrador = null;
            this.AsignarCosto();
        }

        public void AsignarAdmin(Administrador admin)
        {
            if (this.administrador == null && admin.Disponible)
            {
                this.administrador = admin;
                admin.Disponible = false;
            }
            //Agregar excepcion para administrador no disponible o cancha con administrador
        }

        public void QuitarAdmin()
        {
            if(this.administrador != null)
            {
                this.administrador.Disponible = true;
                this.administrador = null;
            }
            //Agregar excepcion para administrador nulo
        }

        private void AsignarCosto()
        {
            switch (this.tipoCancha)
            {
                case eCancha.Hockey:
                    this.costoBase = 3000;
                    break;
                case eCancha.Futbol:
                    this.costoBase = 4000;
                    break;
                case eCancha.Tenis:
                    this.costoBase = 5000;
                    break;
                default:
                    this.costoBase = 7000;
                    break;
            }
        }

        public virtual void DarDeAlta() { }
        public virtual void DarDeBaja() { }
    }
}