using System;
using System.Collections.Generic;

namespace cefet_ia_trabalhoFinal
{
    class Regra
    {
        public List<Fato> Condicoes { get; }
        public Fato Conclusao { get; }
        public List<Operador> Operadores { get; }

        public Regra(List<Fato> condicoes, Fato conclusao, List<Operador> operadores)
        {

            Conclusao = conclusao;
            Condicoes = condicoes;
            Operadores = operadores;

        }

        public bool isValida() => (Condicoes.Count == Operadores.Count + 1);

        public override string ToString()
        {
            string saida;
            if (isValida())
            {
                saida = "Se ( ";
                int cont = 0;
                foreach (Fato fato in Condicoes)
                {
                    saida += fato.ToString() + " ";
                    if (cont != Condicoes.Count - 1)
                    {
                        saida += Operadores[cont].ToString() + " ";
                    }
                    cont++;
                }
                saida += ") Então " + Conclusao.ToString();
            }
            else
            {
                saida = "Regra inválida.";
            }
            return saida;
        }

    }
}
