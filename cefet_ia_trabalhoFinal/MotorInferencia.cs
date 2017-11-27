using System;
using System.Collections.Generic;

namespace cefet_ia_trabalhoFinal
{
    class MotorInferencia
    {
        public BaseConhecimento baseConhecimento { get; }

        public MotorInferencia(BaseConhecimento baseConhecimento)
        {
            this.baseConhecimento = baseConhecimento;
        }

        private bool verificaSintoma(List<Fato> sintomas, Fato sintoma)
        {
            foreach (Fato s in sintomas)
            {
                if (s.Nome.Equals(sintoma.Nome))
                {
                    return true;
                }
            }
            return false;
        }


        public Dictionary<string, Fato> buscar(List<Fato> sintomas)
        {
            Dictionary<string, Fato> doencas = new Dictionary<string, Fato>();
            foreach (Regra regra in baseConhecimento.Regras)
            {
                if (regra.isValida())
                {
                    List<bool> resultados = new List<bool>();
                    foreach (Fato condicao in regra.Condicoes)
                    {
                        resultados.Add(verificaSintoma(sintomas, condicao));
                    }
					bool retirados=false;
					for(int i=0, j=0; i<regra.Operadores.Count;i++,j++){
                        if(regra.Operadores[i].Equals(Operador.OU)){
                            resultados[j]=resultados[j]||resultados[j+1];
							resultados.RemoveAt(j+1);
							retirados=true;
							i++;
							while (i<regra.Operadores.Count && regra.Operadores[i].Equals(Operador.OU))
							{ 
								resultados[j] = resultados[j]||resultados[j+1];							
								resultados.RemoveAt(j+1);
								i++;
							}
							i--;
                        }else{
							if (retirados){
								j--;
								retirados=false;
							}
						}
                    }
					
                    
					bool resultado=resultados[0];
					foreach(bool r in resultados){
						if (resultado==false){
							break;
						}
                        resultado=resultado&&r;
                    }
                    
                    
                    if (resultado)
                    {
                        if (!doencas.ContainsKey(regra.Conclusao.Nome))
                        {
                            doencas.Add(regra.Conclusao.Nome, regra.Conclusao);
                        }
                    }
                }
            }
            return doencas;
        }
    }
}
