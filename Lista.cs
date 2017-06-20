using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Circulares_Atención_de_procesos
{
    class Lista
    {
        static Random probabilidad = new Random();
        private Procesos primero;
        private Procesos ultimo;
        private Procesos temp;
        public string mostrar = "";

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public int probabilidadAgregar()
        {
            int agregar = probabilidad.Next(1, 5);

            if (agregar == 1)
            {
                return 1;
            }
            else
            {
                return -777;
            }
        }

        public void push(Procesos nuevoProceso)
        {
            if (primero == null)
            {
                primero = nuevoProceso;
                ultimo = primero;
                primero.siguiente = primero;
            }
            else
            {
                ultimo.siguiente = nuevoProceso;
                nuevoProceso.siguiente = primero;
                ultimo = nuevoProceso;
            }
        }

        public void eliminar(Procesos procesoPe)
        {
            Procesos tmp = primero;
            Procesos anterior = ultimo;

            primero = primero.siguiente;
            ultimo = primero;
        }

        public Procesos peek()
        {
            return primero;
        }

        public Procesos restar()
        {
            temp = temp.siguiente;

            if (temp.tamañoProceso != 0)
            {
                temp.disminuir();
            }

            return temp;
        }

        public override string ToString()
        {
            Procesos tmp = primero;

            if (tmp != null)
            {
                while (tmp.siguiente != primero)
                {
                    mostrar += tmp.ToString();
                    tmp = tmp.siguiente;
                }
                mostrar += tmp.ToString();
            }

            return mostrar;
        }
  }
}
