using System;
using System.Collections.Generic;

namespace cefet_ia_trabalhoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //doenças
            Doenca cancer= new Doenca("CancerPulmao"); //1
            Doenca asma= new Doenca("Asma"); //8

            //sintomas
            Sintoma alteracaoFala= new Sintoma("Alteração na fala");
            Sintoma alteracaoVisao= new Sintoma("Alteração na visão");
            Sintoma ansiedade= new Sintoma("Ansiedade");
            Sintoma apertoPeito= new Sintoma("Aperto no peito");

            Sintoma batCarAnormal= new Sintoma("Batimento cardíaco anormal");
            
            Sintoma calafrios = new Sintoma("Calafrios");
            Sintoma confusao= new Sintoma("Confusão");

            Sintoma dificultadeRespiratoria = new Sintoma("Dificultade respiratória");
            Sintoma dorCabeca = new Sintoma("Dor de cabeça");
            Sintoma dorGarganta= new Sintoma("Dor de Garganta");
            Sintoma dorPeito= new Sintoma("Dor no peito");
            
            Sintoma extrmoCansaco= new Sintoma("Extremo cansaço");

            Sintoma fadiga= new Sintoma("Fadiga");
            Sintoma faltaAr=new Sintoma ("Falta de ar");
            Sintoma febre = new Sintoma("Febre");
            Sintoma fomeExcessiva=new Sintoma ("Fome excessiva");
            Sintoma formigamentoBraco= new Sintoma("Formigamento nos braços");
            Sintoma formigamentoFace= new Sintoma("Formigamento na face");
            Sintoma fraqueza= new Sintoma("Fraqueza");
            
            Sintoma inchacoAbdomen = new Sintoma("Inchaco abdomen");
            Sintoma inchacoFace = new Sintoma("Inchaco face");
            Sintoma inchacoGarganta = new Sintoma("Inchaco garganta");

            Sintoma miccaoFrequente=new Sintoma ("Micção frequente");
            Sintoma macicatriz=new Sintoma("Má cicatrização");
            Sintoma manchasPele=new Sintoma ("Manchas na pele");
            Sintoma mauHalito=new Sintoma("Mau hálito");

            Sintoma perdaPeso= new Sintoma("Perda de peso");
            Sintoma perdaApetite= new Sintoma("Perda de apetite");
            Sintoma perdaCoordenacao= new Sintoma("Perda de coordenação");
            Sintoma pruidoAnal= new Sintoma("Pruido Anal");
            Sintoma peleAmarela=new Sintoma("Pele amarelada");

            Sintoma ronquidao=new Sintoma("Ronquidao");

            Sintoma sedeExcessiva=new Sintoma ("Sede excessiva");
            Sintoma sudorese=new Sintoma ("Sudorese");

            Sintoma tosse= new Sintoma("Tosse");
            Sintoma tossePus = new Sintoma("Tosse com pus");
            Sintoma tosseCataro = new Sintoma("Tosse com cataro");
            Sintoma tosseSeca = new Sintoma("Tosse seca");
            Sintoma tosseSangue = new Sintoma("Tosse sangue");
            Sintoma tontura= new Sintoma("Tontura");    
            
            Sintoma visaoTurva=new Sintoma ("Visão turva");
            Sintoma vomito=new Sintoma("Vômito");
            
            
            
            //Relação doencas e sintomas
            //sintomas AVC
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

            //sintomas infarte
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

            //sintomas pneumonia
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

            //sintomas diabetes
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
            operadoresDiabetes1.Add(ou); 
            sintomasDiabetes1.Add(macicatriz);
            Regra regraDiabetes1= new Regra(sistomasDiabetes1,diabetes1,operadoresDiabetes1);
            //sintomas Cancer pulmao
            List<Fato> sistomasCancerPulmao= new List<Fato>();
            List<Operador> operadoresCancerPulmao= new List<Operador>();
            sintomasCancerPulmao.Add(tosse);
            operadoresCancerPulmao.Add(e);
            sintomasCancerPulmao.Add(faltaAr);
            operadoresCancerPulmao.Add(e);
            sintomasCancerPulmao.Add(dorPeito);
            operadoresCancerPulmao.Add(e);
            sintomasCancerPulmao.Add(tosseSangue);
            operadoresCancerPulmao.Add(ou);
            sintomasCancerPulmao.Add(inchacoGarganta);
            operadoresCancerPulmao.Add(ou);
            sintomasCancerPulmao.Add(inchacoFace);
            operadoresCancerPulmao.Add(e);
            sintomasCancerPulmao.Add(perdaPeso);
            Regra regraCirrose= new Regra(sistomasCancerPulmao,cancerPulmao,operadoresCancerPulmao);

            //sintomas Cirrose
            List<Fato> sistomasCirrose= new List<Fato>();
            List<Operador> operadoresCirrose= new List<Operador>();
            sintomasCirrose.Add(peleAmarela);
            operadoresCirrose.Add(e);
            sintomasCirrose.Add(inchacoAbdomen);
            operadoresCirrose.Add(e);
            sintomasCirrose.Add(perdaPeso);
            operadoresCirrose.Add(e);
            sintomasCirrose.Add(fraqueza);
            operadoresCirrose.Add(e);
            sintomasCirrose.Add(perdaApetite);
            operadoresCirrose.Add(e);
            sintomasCirrose.Add(mauHalito);
            operadoresCirrose.Add(e);
            sintomasCirrose.Add(manchasPele);
            operadoresCirrose.Add(ou);
            sintomasCirrose.Add(tosse);
            operadoresCirrose.Add(ou);
            sintomasCirrose.Add(vomito);
            Regra regraCirrose= new Regra(sistomasCirrose,cirrose,operadoresCirrose);

            //Sintomas Tuberculose
            List<Fato> sistomasTuberculose= new List<Fato>();
            List<Operador> operadoresTuberculose= new List<Operador>();
            sintomasTuberculose.Add(febre);
            operadoresTuberculose.Add(e);
            sintomasTuberculose.Add(tosseSeca);
            operadoresTuberculose.Add(ou);
            sintomasTuberculose.Add(tosseCataro);
            operadoresTuberculose.Add(e);
            sintomasTuberculose.Add(faltaAr);
            operadoresTuberculose.Add(e);
            sintomasTuberculose.Add(perdaPeso);
            Regra regraTuberculose= new Regra(sistomasTuberculose,tuberculose,operadoresTuberculose);

            //sintomas Dengue
            List<Fato> sistomasDengue= new List<Fato>();            
            List<Operador> operadoresDengue= new List<Operador>();
            sistomasDengue.Add(tontura);
            operadoresDengue.Add(ou);
            sistomasDengue.Add(dorCabeca);
            operadoresDengue.Add(e);
            sistomasDengue.Add(extremoCansaco);
            operadoresDengue.Add(e);
            sistomasDengue.Add(febre);
            operadoresDengue.Add(e);
            sistomasDengue.Add(manchasPele);
            Regra regraDengue= new Regra(sistomasDengue,dengue,operadoresDengue);

            
            //sintomas oxiurus
            List<Fato> sistomasOxi= new List<Fato>();
            sistomasOxi.Add(pruidoAnal);
            List<Operador> operadoresOxi= new List<Operador>();
            Operador e = Operador.E;
            Operador ou = Operador.OU;
    
            //Sintomas Gripe
            List<Fato> sistomasGripe= new List<Fato>();
            sistomasGripe.Add(dorGarganta);
            sistomasGripe.Add(tosse);
            List<Operador> operadoresGripe= new List<Operador>();
            operadoresGripe.Add(Operador.E);
            Regra regraGripe= new Regra(sistomasGripe,gripe,operadoresGripe);

            //SINTOMAS DA DOENCA DO USUARIO
            List<Fato> sistomas= new List<Fato>();
            sistomas.Add(miccaoFrequente);
            sistomas.Add(visaoTurva);
            sistomas.Add(sudorese);
            sistomas.Add(sedeExcessiva);

            //Console.WriteLine(baseConhecimento.ToString());             
           
            MotorInferencia motorInferencia= new MotorInferencia(baseConhecimento);

            
            Dictionary<string, Fato> doencas= motorInferencia.buscar(sistomas);
            
            

            BaseConhecimento baseConhecimento = new BaseConhecimento();
            baseConhecimento.AdicionaRegra(regraInfarto);            
            baseConhecimento.AdicionaRegra(regraAVC);  
            baseConhecimento.AdicionaRegra(regraPneumonia);         
            baseConhecimento.AdicionaRegra(regraDiabetes1);  
            baseConhecimento.AdicionaRegra(regraDengue);
            baseConhecimento.AdicionaRegra(regraGripe);
            baseConhecimento.AdicionaRegra(regraTuberculose);
            baseConhecimento.AdicionaRegra(regraCirrose);
            baseConhecimento.AdicionaRegra(regraCancerPulmao);
            
            Console.WriteLine("Doenças encontradas:");
            foreach (KeyValuePair<string, Fato> doenca in doencas ){
                Console.WriteLine(doenca.Value.ToString());
            }
        }
    }
}
