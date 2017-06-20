using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares_Atención_de_procesos
{
    class Procesos
    {
        Random random = new Random();
        public Procesos siguiente;
        public Procesos tmp;
        private int _tamañoProceso;

        public Procesos()
        {
            _tamañoProceso = random.Next(4, 15);
        }

        public int tamañoProceso
        {
            get { return _tamañoProceso; }
        }

        public int disminuir()
        {
            int disminuir = _tamañoProceso--;
            return disminuir;
        }

        public override string ToString()
        {
            return "Proceso: " + _tamañoProceso + "\r\n";
        }
    }
}

