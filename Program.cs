using System;
using System.Collections.Generic;

namespace cefet_ia_trabalhoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Sintoma dorGarganta= new Sintoma("Dor de Garganta");
            Sintoma tosse= new Sintoma("Tosse");
            Sintoma pruidoAnal= new Sintoma("Pruido Anal");
            
            Doenca cancer= new Doenca("Cancer");
            Doenca oxiuros= new Doenca("Oxiuros");
            Doenca gripe= new Doenca("Gripe");

            List<Fato> sistomasGripe= new List<Fato>();
            sistomasGripe.Add(dorGarganta);
            sistomasGripe.Add(tosse);
            List<Operador> operadoresGripe= new List<Operador>();
            operadoresGripe.Add(Operador.E);

            Regra regraGripe= new Regra(sistomasGripe,gripe,operadoresGripe);

            List<Fato> sistomasOxi= new List<Fato>();
            sistomasOxi.Add(pruidoAnal);
            List<Operador> operadoresOxi= new List<Operador>();

            Regra regraOxi= new Regra(sistomasOxi,oxiuros,operadoresOxi);
            
            BaseConhecimento baseConhecimento = new BaseConhecimento();
            baseConhecimento.AdicionaRegra(regraGripe);            
            baseConhecimento.AdicionaRegra(regraOxi);            
           
            MotorInferencia motorInferencia= new MotorInferencia(baseConhecimento);

            List<Fato> sistomas= new List<Fato>();
            sistomas.Add(pruidoAnal);
            sistomas.Add(tosse);
            sistomas.Add(dorGarganta);
            
            Dictionary<string, Fato> doencas= motorInferencia.buscar(sistomas);
            
            Console.WriteLine("Doenças encontradas:");
            foreach (KeyValuePair<string, Fato> doenca in doencas ){
                Console.WriteLine(doenca.Value.ToString());
            }
        }
    }
}
