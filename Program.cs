using System;
using System.Collections.Generic;

namespace cefet_ia_trabalhoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
Operador e = Operador.E;
Operador ou = Operador.OU;

            Sintoma dorPeito= new Sintoma("Dor no peito");
            Sintoma apertoPeito= new Sintoma("Aperto no peito");
            Sintoma formigamentoBraco= new Sintoma("Formigamento nos braços");
            Sintoma fadiga= new Sintoma("Fadiga");
            Sintoma tontura= new Sintoma("Tontura");    
            Sintoma batCarAnormal= new Sintoma("Batimento cardíaco anormal");
            Sintoma ansiedade= new Sintoma("Ansiedade");
            Sintoma fraqueza= new Sintoma("Fraqueza");
            Sintoma formigamentoFace= new Sintoma("Formigamento na face");
            Sintoma confusao= new Sintoma("Confusão");
            Sintoma alteracaoFala= new Sintoma("Alteração na fala");
            Sintoma alteracaoVisao= new Sintoma("Alteração na visão");
            Sintoma perdaCoordenacao= new Sintoma("Perda de coordenação");
            Sintoma dorCabeca = new Sintoma("Dor de cabeça");
            Sintoma tossePus = new Sintoma("Tosse com pus");
            Sintoma tosseCataro = new Sintoma("Tosse com cataro");
            Sintoma tosseSeca = new Sintoma("Tosse seca");
            Sintoma febre = new Sintoma("Febre");
            Sintoma calafrios = new Sintoma("Calafrios");
            Sintoma dificultadeRespiratoria = new Sintoma("Dificultade respiratória");
            Sintoma faltaAr=new Sintoma ("Falta de ar");
            Sintoma sedeExcessiva=new Sintoma ("Sede excessiva");
            Sintoma miccaoFrequente=new Sintoma ("Micção frequente");
            Sintoma fomeExcessiva=new Sintoma ("Fome excessiva");
            Sintoma visaoTurva=new Sintoma ("Visão turva");
            Sintoma sudorese=new Sintoma ("Sudorese");
            
            Doenca avc =new Doenca("Derrame cerebral (AVC)");  
            List<Fato> sistomasAVC= new List<Fato>();            
            List<Operador> operadoresAVC= new List<Operador>();
            sistomasAVC.Add(formigamentoFace);     
            operadoresAVC.Add(ou);
            sistomasAVC.Add(formigamentoBraco);     
            operadoresAVC.Add(e);
            sistomasAVC.Add(confusao);        
            operadoresAVC.Add(ou);        
            sistomasAVC.Add(alteracaoFala);      
            operadoresAVC.Add(ou);     
            sistomasAVC.Add(alteracaoVisao);     
            operadoresAVC.Add(e);
            sistomasAVC.Add(tontura);     
            operadoresAVC.Add(ou);
            sistomasAVC.Add(fraqueza); 
            operadoresAVC.Add(ou);
            sistomasAVC.Add(perdaCoordenacao);      
            operadoresAVC.Add(e);
            sistomasAVC.Add(dorCabeca); 
            Regra regraAVC= new Regra(sistomasAVC,avc,operadoresAVC);
                          
            Doenca infarto =new Doenca("Infarto");
            List<Fato> sistomasInfarto= new List<Fato>();
            List<Operador> operadoresInfarto= new List<Operador>();
            sistomasInfarto.Add(apertoPeito);
            operadoresInfarto.Add(ou);
            sistomasInfarto.Add(dorPeito);
            operadoresInfarto.Add(e);
            sistomasInfarto.Add(formigamentoBraco);
            operadoresInfarto.Add(e);
            sistomasInfarto.Add(batCarAnormal);
            operadoresInfarto.Add(ou);
            sistomasInfarto.Add(fadiga);
            operadoresInfarto.Add(ou);
            sistomasInfarto.Add(tontura);
            operadoresInfarto.Add(ou);            
            sistomasInfarto.Add(ansiedade);
            Regra regraInfarto= new Regra(sistomasInfarto,infarto,operadoresInfarto);
            
            Doenca pneumonia =new Doenca("Pneumonia");
            List<Fato> sistomasPneumonia= new List<Fato>();
            List<Operador> operadoresPneumonia= new List<Operador>();
            sistomasPneumonia.Add(tosseCataro);
            operadoresPneumonia.Add(ou);
            sistomasPneumonia.Add(tossePus);
            operadoresPneumonia.Add(ou);
            sistomasPneumonia.Add(tosseSeca);
            operadoresPneumonia.Add(e);
            sistomasPneumonia.Add(calafrios);
            operadoresPneumonia.Add(ou); 
            sistomasPneumonia.Add(febre);
            operadoresPneumonia.Add(ou);
            sistomasPneumonia.Add(fadiga);
            operadoresPneumonia.Add(e);
            sistomasPneumonia.Add(dificultadeRespiratoria);
            operadoresPneumonia.Add(ou);            
            sistomasPneumonia.Add(faltaAr);
            operadoresPneumonia.Add(ou);            
            sistomasPneumonia.Add(dorPeito);
            Regra regraPneumonia= new Regra(sistomasPneumonia,pneumonia,operadoresPneumonia);
            
            Doenca diabetes1 =new Doenca("Diabetes tipo 1");
            List<Fato> sistomasDiabetes1= new List<Fato>();
            List<Operador> operadoresDiabetes1= new List<Operador>();
            sistomasDiabetes1.Add(sedeExcessiva);
            operadoresDiabetes1.Add(ou);
            sistomasDiabetes1.Add(fomeExcessiva);
            operadoresDiabetes1.Add(e);
            sistomasDiabetes1.Add(miccaoFrequente);
            operadoresDiabetes1.Add(e);
            sistomasDiabetes1.Add(visaoTurva);
            operadoresDiabetes1.Add(e);
            sistomasDiabetes1.Add(sudorese);
            operadoresDiabetes1.Add(ou); 
            sistomasDiabetes1.Add(fadiga);
            Regra regraDiabetes1= new Regra(sistomasDiabetes1,diabetes1,operadoresDiabetes1);
    

            BaseConhecimento baseConhecimento = new BaseConhecimento();
            baseConhecimento.AdicionaRegra(regraInfarto);            
            baseConhecimento.AdicionaRegra(regraAVC);  
            baseConhecimento.AdicionaRegra(regraPneumonia);         
            baseConhecimento.AdicionaRegra(regraDiabetes1);   

            //Console.WriteLine(baseConhecimento.ToString());             
           
            MotorInferencia motorInferencia= new MotorInferencia(baseConhecimento);

            List<Fato> sistomas= new List<Fato>();
            sistomas.Add(miccaoFrequente);
            sistomas.Add(visaoTurva);
            sistomas.Add(sudorese);
            sistomas.Add(sedeExcessiva);
            
            Dictionary<string, Fato> doencas= motorInferencia.buscar(sistomas);
            
            Console.WriteLine("Doenças encontradas:");
            foreach (KeyValuePair<string, Fato> doenca in doencas ){
                Console.WriteLine(doenca.Value.ToString());
            }
        }
    }
}
