using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    public abstract class Decorador : IAudio
    {
        protected IAudio audio;

        public Decorador(IAudio audio)
        {
            this.audio = audio;
        }

        public virtual void Reproducir()
        {
            audio.Reproducir();
        }
    }
}
