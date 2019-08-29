using System.Collections.Generic;

namespace Spuchifai5719
{
    public abstract class ConListaReproduccion
    {
        public List<Reproduccion> Reproducciones { get; set; }

        public ConListaReproduccion()
        {
            Reproducciones = new List<Reproduccion>();
        }

        public void AgregarReproduccion(Reproduccion reproduccion)
        {
            Reproducciones.Add(reproduccion);
        }
    }
}
