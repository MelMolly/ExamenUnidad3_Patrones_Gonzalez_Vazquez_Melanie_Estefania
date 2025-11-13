using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    public class EfectoDistorsion : Decorador
    {
        public EfectoDistorsion(IAudio audio) : base(audio) { }

        public override void Reproducir()
        {
            base.Reproducir();
            Console.WriteLine("Aplicando efecto DISTORSION...");
        }
    }
}
