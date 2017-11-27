using System;

namespace cefet_ia_trabalhoFinal
{
    class Fato
    {
        public string Nome {get;}
        
        public Fato(string nome){
            Nome=nome;
        }

        public override string ToString()=> Nome;
    }
}
