using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MancD_InfoTest
{
    public abstract class MancD_Disoccupato : MancD_Candidato
    {
        private int _MancD_voto;
        private bool _MancD_lode;

        public int MancD_voto
        {
            get
            {
                return _MancD_voto;
            }
            set
            {
                if (value >= 0 && value <= 110)
                    _MancD_voto = value;
                else
                    throw new Exception("Voto non valido");
            }
        }
        public bool MancD_lode
        {
            get
            {
                return _MancD_lode;
            }
            set
            {
                if (_MancD_voto == 110)
                {
                    try
                    {
                        _MancD_lode = value;
                    }
                    catch
                    {
                        throw new Exception("Lode non valida");
                    }
                }
                else
                    throw new Exception("Lode non disponibile");
            }
        }
        public MancD_Disoccupato() : base()
        {
            MancD_voto = 0;
            MancD_lode = false;
        }
        public MancD_Disoccupato(int n, bool b, int matricola, string nome) : base(matricola, nome)
        {
            MancD_voto = n;
            MancD_lode = b;
        }
        public override int punteggio()
        {
            int p = (MancD_voto * 100) / 110;
            if (MancD_lode)
                p += 5;

            return p;
        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 72)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            string l = null;
            if (MancD_lode)
                l = "e lode";

            string s = $"{MancD_Matricola}:{MancD_Nome};voto:{MancD_voto} " + l;
            return s;
        }
        public bool Equals(MancD_Disoccupato c)
        {
            if (c == null)
                return false;
            if (this == c)
                return true;
            if (this.MancD_Matricola == c.MancD_Matricola || this.MancD_Nome == c.MancD_Nome || this.MancD_voto == c.MancD_voto || this.MancD_lode == c.MancD_lode)
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