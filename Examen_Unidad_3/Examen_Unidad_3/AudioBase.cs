using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    public class AudioBase : IAudio
    {
        private string archivo;

        public AudioBase(string archivo)
        {
            this.archivo = archivo;
        }

        public void Reproducir()
        {
            Console.WriteLine($"Reproduciendo archivo: {archivo}");
        }
    }
}
