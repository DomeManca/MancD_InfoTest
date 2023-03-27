using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MancD_InfoTest
{
    public abstract class MancD_Lavoratore : MancD_Candidato
    {
        private int _MancD_esperienze;

        public int MancD_esperienze
        {
            get { return _MancD_esperienze; }
            set {
                if (value >= 0 && value <= 5)
                    _MancD_esperienze = value;
                else
                    throw new Exception("esperienze non valide");
            }
        }

        public MancD_Lavoratore() : base()
        {
        }
        public MancD_Lavoratore(int esperienze, int matricola,string nome): base (matricola,nome)
        {
            MancD_esperienze = esperienze;
        }
        public override int punteggio()
        {
            int p = (MancD_esperienze * 20);

            return p;
        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            string s = $"{MancD_Matricola}:{MancD_Nome};esperienze:{MancD_esperienze}";
            return s;
        }
        public bool Equals(MancD_Lavoratore c)
        {
            if (c == null)
                return false;
            if (this == c)
                return true;
            if (this.MancD_Matricola == c.MancD_Matricola || this.MancD_Nome == c.MancD_Nome || this.MancD_esperienze == c.MancD_esperienze)
                return true;
            else
                return false;
        }
        public override bool CompareTo(MancD_Candidato c)
        {
            if (this.punteggio() == c.punteggio())
                return true;
            else
                return false;
        }
    }
}
