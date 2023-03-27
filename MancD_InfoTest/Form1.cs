using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MancD_InfoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        List<MancD_Candidato> Candidati = new List<MancD_Candidato>();
        public void Aggiunta(MancD_Candidato c)
        {
            Candidati.Add(c);
        }
        public string[] Visualizza()
        {
            string[] lista = new string[999];
            int count = 0;
            foreach (MancD_Candidato c in Candidati)
            {
                lista[count] = c.ToString();
                count++;
            }
            return lista;
        }
        public void Modifica(string n, int m)
        {
            for (int i = 0; i < Candidati.Count; i++)
            {
                if (Candidati[i].MancD_Matricola == m)
                {
                    Candidati[i].MancD_Nome = n;
                }
            }
        }
        public void Elimina(int m)
        {
            for (int i = 0; i < Candidati.Count; i++)
            {
                if (Candidati[i].MancD_Matricola == m)
                {
                    Candidati[i] = null;
                }
            }
        }
        public string[] VisualizzaIdonei()
        {
            string[] lista = new string[999];
            int count = 0;
            foreach (MancD_Candidato c in Candidati)
            {
                if(c.isIdoneo())
                    lista[count] = c.ToString();

                count++;
            }
            return lista;
        }
        //no ordinamento
    }
}
