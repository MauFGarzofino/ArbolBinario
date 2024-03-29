﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class ArbolBinario
    {
        public TNodoArbol raiz;
        public TNodoArbol EnlaceIzquierdo;
        public TNodoArbol EnlaceDerecho;
        public ArbolBinario()
        {
            raiz = null;
            EnlaceIzquierdo = null;
            EnlaceDerecho = null;
        }

        public Boolean vacio()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void InsertarRaiz(TNodoArbol a)
        {

            if (vacio())
            {
                raiz = a;
            }
        }

        public void Insertar(TNodoArbol a, TNodoArbol padre)
        {
            if (padre.EnlaceIzquierdo == null)
            {
                padre.EnlaceIzquierdo = a;
            }
            else
                padre.EnlaceDerecho = a;
        }

        public void InsertarIzq(TNodoArbol a, TNodoArbol padre)
        {
            if (padre.EnlaceIzquierdo == null)
                padre.EnlaceIzquierdo = a;
            else
                System.Windows.Forms.MessageBox.Show("Error: enlace lleno");
        }

        public void InsertarDer(TNodoArbol a, TNodoArbol padre)
        {
            if (padre.EnlaceDerecho == null)
                padre.EnlaceDerecho = a;
            else
                System.Windows.Forms.MessageBox.Show("Error: enlace lleno");
        }

        public void EliminarDerecho(TNodoArbol padre)
        {
            //
            if(padre.EnlaceDerecho != null)
            {
                TNodoArbol aux;
                aux = padre.EnlaceDerecho;
                padre.EnlaceDerecho = null;
                System.Windows.Forms.MessageBox.Show("El elemento eliminado es : " + aux.info);
            }else
                System.Windows.Forms.MessageBox.Show("No existe enlace Derecho");
            //
        }

        public void EliminarIzquierdo(TNodoArbol padre)
        {
            //
            if (padre.EnlaceIzquierdo != null)
            {
                TNodoArbol aux;
            aux = padre.EnlaceIzquierdo;
            padre.EnlaceIzquierdo = null;
            System.Windows.Forms.MessageBox.Show("El elemento eliminado es : " + aux.info);
            }else
                System.Windows.Forms.MessageBox.Show("No existe enlace Derecho");
            //
        }

        private string PreOrden1(TNodoArbol r)
        {
            string result = "";
            if (r != null)
            {
                result += r.info + "  ";
                result += PreOrden1(r.EnlaceIzquierdo);
                result += PreOrden1(r.EnlaceDerecho);
            }
            return result;
        }

        public string PreOrden()
        {
            return PreOrden1(raiz);
        }

        public string EntreOrden(TNodoArbol r)
        {
            string result = "";
            if (r != null)
            {
                result += EntreOrden(r.EnlaceIzquierdo);
                result += r.info + "  ";
                result += EntreOrden(r.EnlaceDerecho);
            }
            return result;
        }

        public string PosOrden(TNodoArbol r)
        {
            string result = "";
            if (r != null)
            {
                result += PosOrden(r.EnlaceIzquierdo);
                result += PosOrden(r.EnlaceDerecho);
                result += r.info + "  ";
            }
            return result;
        }

        private TNodoArbol buscar(TNodoArbol r, string nombre)
        {
            if ((r != null))
            {
                if (r.info == nombre)
                {
                    return r;
                }
                TNodoArbol aux = buscar(r.EnlaceIzquierdo, nombre);
                if (aux != null)
                {
                    return aux;
                }
                else
                {
                    return buscar(r.EnlaceDerecho, nombre);
                }
            }
            return null;
        }

        public TNodoArbol buscar(string nombre)
        {
            return buscar(raiz, nombre);
        }

    }
}
