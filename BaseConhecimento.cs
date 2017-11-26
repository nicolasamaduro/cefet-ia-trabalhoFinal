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

        public override string ToString(){
            string value="BC\n\n";
            foreach ( Regra regra in Regras)
            {
                value+=regra.ToString()+"\n\n";
            }
            return value;
        }
    }

}
