using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model.Entities
{
    public class AmigosHeroi
    {
        private string hobby;
        private string atividadeProfissional;

        // ---- Construtor ----//

        public AmigosHeroi() : base()
        {
            hobby = null;
            atividadeProfissional = null;  
        }

        //---- Propriedades ----// 
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value;}
        }
        public string AtividadeProfissional
        {
            get { return atividadeProfissional; }
            set { atividadeProfissional = value; }
        }
        //public override void calcularIdade(int anoAtual)
        //{
           // base.Idade = (anoAtual - base.AnoNasc);
        //}

    }

}
