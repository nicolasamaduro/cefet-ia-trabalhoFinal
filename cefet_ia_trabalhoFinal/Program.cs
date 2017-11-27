using cefet_ia_trabalhoFinal.tela;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cefet_ia_trabalhoFinal
{
    class Program
    {
        static void Main(string[] args)
        {


            Operador e = Operador.E;
            Operador ou = Operador.OU;

            List<Fato> sintomas = new List<Fato>();

            //sintomas
            Sintoma alteracaoFala = new Sintoma("Alteração na fala");
            sintomas.Add(alteracaoFala);
            Sintoma alteracaoVisao = new Sintoma("Alteração na visão");
            Sintoma ansiedade = new Sintoma("Ansiedade");
            Sintoma apertoPeito = new Sintoma("Aperto no peito");

            Sintoma batCarAnormal = new Sintoma("Batimento cardíaco anormal");

            Sintoma calafrios = new Sintoma("Calafrios");
            Sintoma confusao = new Sintoma("Confusão");
            Sintoma chiadoPeito = new Sintoma("Chiado no peito");

            Sintoma dificultadeRespiratoria = new Sintoma("Dificultade respiratória");
            Sintoma dorCabeca = new Sintoma("Dor de cabeça");
            Sintoma dorGarganta = new Sintoma("Dor de Garganta");
            Sintoma dorPeito = new Sintoma("Dor no peito");

            Sintoma extremoCansaco = new Sintoma("Extremo cansaço");

            Sintoma fadiga = new Sintoma("Fadiga");
            Sintoma faltaAr = new Sintoma("Falta de ar");
            Sintoma febre = new Sintoma("Febre");
            Sintoma fomeExcessiva = new Sintoma("Fome excessiva");
            Sintoma formigamentoBraco = new Sintoma("Formigamento nos braços");
            Sintoma formigamentoFace = new Sintoma("Formigamento na face");
            Sintoma fraqueza = new Sintoma("Fraqueza");

            Sintoma inchacoAbdomen = new Sintoma("Inchaco abdomen");
            Sintoma inchacoFace = new Sintoma("Inchaco face");
            Sintoma inchacoGarganta = new Sintoma("Inchaco garganta");
            Sintoma irritacaoGarganta = new Sintoma("Irritação Garganta");

            Sintoma miccaoFrequente = new Sintoma("Micção frequente");
            Sintoma macicatriz = new Sintoma("Má cicatrização");
            Sintoma manchasPele = new Sintoma("Manchas na pele");
            Sintoma mauHalito = new Sintoma("Mau hálito");

            Sintoma perdaPeso = new Sintoma("Perda de peso");
            Sintoma perdaApetite = new Sintoma("Perda de apetite");
            Sintoma perdaCoordenacao = new Sintoma("Perda de coordenação");
            Sintoma pruidoAnal = new Sintoma("Pruido Anal");
            Sintoma peleAmarela = new Sintoma("Pele amarelada");
            Sintoma pigarro = new Sintoma("Pigarro");

            Sintoma ronquidao = new Sintoma("Ronquidao");

            Sintoma sedeExcessiva = new Sintoma("Sede excessiva");
            Sintoma sudorese = new Sintoma("Sudorese");

            Sintoma tosse = new Sintoma("Tosse");
            Sintoma tossePus = new Sintoma("Tosse com pus");
            Sintoma tosseCataro = new Sintoma("Tosse com cataro");
            Sintoma tosseSeca = new Sintoma("Tosse seca");
            Sintoma tosseSangue = new Sintoma("Tosse sangue");
            Sintoma tontura = new Sintoma("Tontura");

            Sintoma visaoTurva = new Sintoma("Visão turva");
            Sintoma vomito = new Sintoma("Vômito");



            //Relação doencas e sintomas
            //sintomas AVC
            Doenca avc = new Doenca("AVC");
            List<Fato> sistomasAVC = new List<Fato>();
            List<Operador> operadoresAVC = new List<Operador>();
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
            Regra regraAVC = new Regra(sistomasAVC, avc, operadoresAVC);

            //sintomas infarte
            Doenca infarto = new Doenca("Infarto");
            List<Fato> sistomasInfarto = new List<Fato>();
            List<Operador> operadoresInfarto = new List<Operador>();
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
            Regra regraInfarto = new Regra(sistomasInfarto, infarto, operadoresInfarto);

            //sintomas pneumonia
            Doenca pneumonia = new Doenca("Pneumonia");
            List<Fato> sistomasPneumonia = new List<Fato>();
            List<Operador> operadoresPneumonia = new List<Operador>();
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
            Regra regraPneumonia = new Regra(sistomasPneumonia, pneumonia, operadoresPneumonia);

            //sintomas diabetes
            Doenca diabetes1 = new Doenca("Diabetes tipo 1");
            List<Fato> sintomasDiabetes1 = new List<Fato>();
            List<Operador> operadoresDiabetes1 = new List<Operador>();
            sintomasDiabetes1.Add(sedeExcessiva);
            operadoresDiabetes1.Add(ou);
            sintomasDiabetes1.Add(fomeExcessiva);
            operadoresDiabetes1.Add(e);
            sintomasDiabetes1.Add(miccaoFrequente);
            operadoresDiabetes1.Add(e);
            sintomasDiabetes1.Add(visaoTurva);
            operadoresDiabetes1.Add(e);
            sintomasDiabetes1.Add(sudorese);
            operadoresDiabetes1.Add(ou);
            sintomasDiabetes1.Add(fadiga);
            operadoresDiabetes1.Add(ou);
            sintomasDiabetes1.Add(macicatriz);
            Regra regraDiabetes1 = new Regra(sintomasDiabetes1, diabetes1, operadoresDiabetes1);

            //sintomas Bronquite

            Doenca bronquite = new Doenca("Bronquite");
            List<Fato> sintomasBronquite = new List<Fato>();
            List<Operador> operadoresBronquite = new List<Operador>();
            sintomasBronquite.Add(faltaAr);
            operadoresBronquite.Add(e);
            sintomasBronquite.Add(irritacaoGarganta);
            operadoresBronquite.Add(e);
            sintomasBronquite.Add(tosseCataro);
            operadoresBronquite.Add(e);
            sintomasBronquite.Add(dorPeito);
            operadoresBronquite.Add(e);
            sintomasBronquite.Add(chiadoPeito);
            operadoresBronquite.Add(e);
            sintomasBronquite.Add(pigarro);
            Regra regraBronquite = new Regra(sintomasBronquite, bronquite, operadoresBronquite);

            //sintomas Cancer pulmao
            Doenca cancerPulmao = new Doenca("Câncer de pulmão");
            List<Fato> sintomasCancerPulmao = new List<Fato>();
            List<Operador> operadoresCancerPulmao = new List<Operador>();
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
            Regra regraCancerPulmao = new Regra(sintomasCancerPulmao, cancerPulmao, operadoresCancerPulmao);

            //sintomas Cirrose
            Doenca cirrose = new Doenca("Cirrose");
            List<Fato> sintomasCirrose = new List<Fato>();
            List<Operador> operadoresCirrose = new List<Operador>();
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
            Regra regraCirrose = new Regra(sintomasCirrose, cirrose, operadoresCirrose);

            //Sintomas Tuberculose
            Doenca tuberculose = new Doenca("Tuberculose");
            List<Fato> sintomasTuberculose = new List<Fato>();
            List<Operador> operadoresTuberculose = new List<Operador>();
            sintomasTuberculose.Add(febre);
            operadoresTuberculose.Add(e);
            sintomasTuberculose.Add(tosseSeca);
            operadoresTuberculose.Add(ou);
            sintomasTuberculose.Add(tosseCataro);
            operadoresTuberculose.Add(e);
            sintomasTuberculose.Add(faltaAr);
            operadoresTuberculose.Add(e);
            sintomasTuberculose.Add(perdaPeso);
            Regra regraTuberculose = new Regra(sintomasTuberculose, tuberculose, operadoresTuberculose);

            //sintomas Dengue
            Doenca dengue = new Doenca("Dengue");
            List<Fato> sintomasDengue = new List<Fato>();
            List<Operador> operadoresDengue = new List<Operador>();
            sintomasDengue.Add(tontura);
            operadoresDengue.Add(ou);
            sintomasDengue.Add(dorCabeca);
            operadoresDengue.Add(e);
            sintomasDengue.Add(extremoCansaco);
            operadoresDengue.Add(e);
            sintomasDengue.Add(febre);
            operadoresDengue.Add(e);
            sintomasDengue.Add(manchasPele);
            Regra regraDengue = new Regra(sintomasDengue, dengue, operadoresDengue);

            BaseConhecimento baseConhecimento = new BaseConhecimento();
            baseConhecimento.AdicionaRegra(regraAVC);        
            baseConhecimento.AdicionaRegra(regraBronquite);  
            baseConhecimento.AdicionaRegra(regraCancerPulmao);         
            baseConhecimento.AdicionaRegra(regraCirrose); 
            baseConhecimento.AdicionaRegra(regraDengue);
            baseConhecimento.AdicionaRegra(regraDiabetes1); 
            baseConhecimento.AdicionaRegra(regraInfarto);
            baseConhecimento.AdicionaRegra(regraPneumonia);
            baseConhecimento.AdicionaRegra(regraTuberculose);

            MotorInferencia motorInferencia= new MotorInferencia(baseConhecimento);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Tela tela = new Tela(motorInferencia, sintomas);
            Application.Run(tela);
        }
    }
}
