using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_y_Colas
{
     class Pila
    {
        //Elementos de la pila
        public int cima;
        private int maximo;
        public int[] lapila;

        //Crear metodo constructor
        public Pila() { }
        public Pila(int m)
        {
            this.maximo = m;
            cima = -1;
            lapila = new int[maximo];
        }
        /* metodo pila llena*/
        public Boolean pila_llena()
        {
            if(cima== maximo-1)
                return true;
            else 
                return false;
        }
        public Boolean Pila_vacia()
        {
            if (cima==-1)
                return true;
            else
                return false;
        }
        public void push (int n)
        {
            if (pila_llena() == true)
                MessageBox.Show("Pila llena ");
            else
            {
                cima++;
                lapila[cima] = n;
            }
        }
        public int pop()
        {
            int n = -2;
            if (Pila_vacia() == true)
                MessageBox.Show("Pila vacia");
            else
            {
                n = lapila[cima];
                cima--;
            }
            return n;
        }
    }
}
