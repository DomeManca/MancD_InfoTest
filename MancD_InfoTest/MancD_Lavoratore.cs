﻿using System;
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
    }
}
