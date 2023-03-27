using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MancD_InfoTest
{
    public abstract class MancD_Candidato
    {
        private int _MancD_Matricola;
        private string _MancD_Nome;

        public int MancD_Matricola
        {
            get { return _MancD_Matricola; }
            set { _MancD_Matricola = value; }
        }
        public string MancD_Nome
        {
            get { return _MancD_Nome; }
            set { _MancD_Nome = value; }
        }
        public MancD_Candidato()
        {
            MancD_Matricola = 0;
            MancD_Nome = null;
        }
        public MancD_Candidato(int n)
        {
            MancD_Matricola = n;
            MancD_Nome = null;
        }
        public MancD_Candidato(string s)
        {
            MancD_Matricola = 0;
            MancD_Nome = s;
        }
        public MancD_Candidato(int n, string s)
        {
            MancD_Matricola = n;
            MancD_Nome = s;
        }
        public abstract bool isIdoneo();
        public abstract int punteggio();
    }
}
