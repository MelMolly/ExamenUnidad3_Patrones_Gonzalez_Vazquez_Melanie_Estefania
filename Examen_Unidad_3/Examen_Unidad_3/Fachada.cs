using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    public class Fachada
    {
        public void AudioConEfectos(string archivo, bool eco, bool distorsion, bool reverb, bool graves, bool agudos)
        {
            IAudio audio = new AudioBase(archivo);

            if(eco)
                audio = new EfectoEco(audio);
            if(distorsion)
                audio = new EfectoDistorsion(audio);
            if(reverb)
                audio = new EfectoReverberacion(audio);
            if(graves)
                audio = new EfectoGravesIntensos(audio);
            if (agudos)
                audio = new EfectoAgudosIntensos(audio);

            Console.WriteLine("\nIniciando reproducción con efectos seleccionados...");
            audio.Reproducir();
        }

        public void ReproducirSimple(string archivo)
        {
            IAudio audio = new AudioBase(archivo);
            audio.Reproducir();
        }
    }
}
