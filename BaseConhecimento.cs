using System;
using System.Collections.Generic;

namespace cefet_ia_trabalhoFinal
{
    class BaseConhecimento
    {
        public List<Regra> Regras {get;}
        
        public BaseConhecimento(){
            Regras=new List<Regra>();
        }

        public void AdicionaRegra(Regra regra){
            Regras.Add(regra);
        }
    }
}
