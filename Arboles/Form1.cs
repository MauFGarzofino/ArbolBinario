using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
        
        ArbolBinario Arbol1 = new ArbolBinario();

        public Form1(){
            InitializeComponent();    
        }

        private void dsa_Click(object sender, EventArgs e)
        {
                if(raizbox.Text == string.Empty)
                {
                    MessageBox.Show("Inserte la raìz");
                }
                else
                {
                    string s = raizbox.Text;
                    TNodoArbol raiz = new TNodoArbol(s);
                    Arbol1.InsertarRaiz(raiz);

                    label2.Text = "disabled";
                    dsa.Enabled = false;
                }
    }

        private void InsertarIzquierda_Click(object sender, EventArgs e)
        {
            if (padre.Text == string.Empty || hijo.Text == string.Empty)
            {
                MessageBox.Show("Inserte Los Datos");
            }
            else
            {
                TNodoArbol a = new TNodoArbol(hijo.Text);
            Arbol1.InsertarIzq(a, Arbol1.buscar(padre.Text));
            }
        }

        private void InsertarDerecha_Click(object sender, EventArgs e)
        {
            if (padre.Text == string.Empty || hijo.Text == string.Empty)
            {
                MessageBox.Show("Inserte Los Datos");
            }
            else
            {
                TNodoArbol a = new TNodoArbol(hijo.Text);
                Arbol1.InsertarDer(a, Arbol1.buscar(padre.Text));
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Arbol1.vacio())
            {
                MessageBox.Show("Àrbol Vacìo");
            }else
            ordenLabel.Text = Arbol1.PreOrden();
        }

        private void entreorden_Click(object sender, EventArgs e)
        {
            if (Arbol1.vacio())
            {
                MessageBox.Show("Àrbol Vacìo");
            }
            else
                ordenLabel.Text = Arbol1.EntreOrden(Arbol1.raiz);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Arbol1.vacio())
            {
                MessageBox.Show("Àrbol Vacìo");
            }
            else
                ordenLabel.Text = Arbol1.PosOrden(Arbol1.raiz);
        }

        private void EliminarDerecha_Click(object sender, EventArgs e)
        {
            if (padre.Text == string.Empty || hijo.Text == string.Empty)
            {
                MessageBox.Show("Inserte Los Datos");
            }else
            if (Arbol1.vacio())
            {
                MessageBox.Show("Àrbol Vacìo");
            }
            else
                Arbol1.EliminarDerecho(Arbol1.buscar(padre.Text));
        }

        private void EliminarIzquierda_Click(object sender, EventArgs e)
        {
            if (padre.Text == string.Empty || hijo.Text == string.Empty)
            {
                MessageBox.Show("Inserte Los Datos");
            }else
            if (Arbol1.vacio())
            {
                MessageBox.Show("Àrbol Vacìo");
            }
            else
                Arbol1.EliminarIzquierdo(Arbol1.buscar(padre.Text));
        }
        
}
}
