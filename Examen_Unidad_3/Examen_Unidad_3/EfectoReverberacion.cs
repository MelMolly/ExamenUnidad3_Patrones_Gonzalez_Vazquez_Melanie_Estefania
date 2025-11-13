using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    public class EfectoReverberacion : Decorador
    {
        public EfectoReverberacion(IAudio audio) : base(audio) { }

        public override void Reproducir()
        {
            base.Reproducir();
            Console.WriteLine("Aplicando efecto Reverberación...");
        }
    }
}
