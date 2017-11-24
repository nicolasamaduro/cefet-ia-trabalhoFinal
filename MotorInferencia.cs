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
                    int i = 0;
                    bool resultado = false;
                    if (regra.Operadores.Count == 0)
                    {
                        resultado = resultados[0];
                    }
                    else
                    {
                        foreach (Operador operador in regra.Operadores)
                        {
                            if (operador.Equals(Operador.E))
                            {
                                resultado = resultado || (resultados[i] && resultados[i + 1]);
                            }
                            else
                            {
                                resultado = resultado || (resultados[i] || resultados[i + 1]);
                            }
                            i++;
                        }
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
