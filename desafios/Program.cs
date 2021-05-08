using System;

namespace desafios
{
    class Program
    {
        static void Main(string[] args)
        {
           // CrescimentoPopulacional();
          //  Bazinga();
          TempoEvento();
        }
public static void TempoEvento(){
     int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
        int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;
        //continue escrevendo a solucao

        string[] dadosInicio = Console.ReadLine().Split();
        diaInicio = Convert.ToInt32(dadosInicio[1]);

        string[] dadosMomentoInicio = Console.ReadLine().Split(":");
        horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
        minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
        segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);


        string[] dadosTermino = Console.ReadLine().Split();
        diaTermino = Convert.ToInt32(dadosTermino[1]);

        string[] dadosMomentoTermino = Console.ReadLine().Split(":");
        horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
        minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
        segundoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);


        int transformaSegundosInicio = (segundoMomentoInicio + (diaInicio * 86400) + (horaMomentoInicio * 3600) + (minutoMomentoInicio * 60));
        int transformaSegundosTermino = (segundoMomentoTermino + (diaTermino * 86400) + (horaMomentoTermino * 3600) + (minutoMomentoTermino * 60));
        int somaTotalSegundos = (transformaSegundosTermino - transformaSegundosInicio);

        int W = somaTotalSegundos / 86400;
        int X = (somaTotalSegundos - (W * 86400)) / 3600;
        int Y = (somaTotalSegundos - ((W * 86400) + (X * 3600))) / 60;
        int Z = somaTotalSegundos - ((W * 86400) + (X * 3600) + (Y * 60));


        Console.WriteLine("{0} dia(s)", W);
        Console.WriteLine("{0} hora(s)", X);
        Console.WriteLine("{0} minuto(s)", Y);
        Console.WriteLine("{0} segundo(s)", Z);
        
Console.ReadLine();

}
        public static void CrescimentoPopulacional()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                //declare as variaveis corretamente
                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]);

                while (pa <= pb)
                {

                    //complete o while
                    pa = (int)(((pa * cpa) / 100) + pa);
                    pb = (int)(((pb * cpb) / 100) + pb);
                    anos++;

                    if (anos > 100)
                    {
                        //complete a condicional
                        Console.WriteLine("Mais de 1 seculo.");
                        pa = pb + 1;
                    }
                }

                if (anos <= 100)
                {
                    //complete a condicional
                    Console.WriteLine("{0} anos.", anos);
                }

            }
            Console.ReadLine();

        }
        public static void Bazinga(){

              int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <=qtdTeste ; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
               if ((v1 == "tesoura" && v2 == "papel") || (v1 == "papel" && v2 == "pedra") //complete a solução
                || (v1 == "pedra" && v2 == "lagarto") || (v1 == "lagarto" && v2 == "Spock")
                || (v1 == "Spock" && v2 == "tesoura") || (v1 == "tesoura" && v2 == "lagarto")
                || (v1 == "lagarto" && v2 == "papel") || (v1 == "papel" && v2 == "Spock")
                || (v1 == "Spock" && v2 == "pedra") || (v1 == "pedra" && v2 == "tesoura"))
                Console.WriteLine("Caso #{0}: Bazinga!", i);
            else if (v1 == v2)   //complete a solucao
                Console.WriteLine("Caso #{0}: De novo!", i);
            else
                Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
            Console.ReadLine();
        }
    }

}
