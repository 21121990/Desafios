using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            // CrescimentoPopulacional();
            //  Bazinga();
            // TempoEvento();
            // Inverter();
            // Coordenadas();
            // ComprasSupermercado();
            // Multiplos();
            // DataPizza();
            // UltrapassarV();
            // converterTempo(); 
            // NotasMoedas();
            // FormulaBhaskara();
            // CoxinhaBueno();
            // CardapioAerio();
            // VisitaFeira();
            // Tuitando();
            // ValidacaoNota();
            // Triangulo();
            // DivisaoEuclidiana();
            //TiposTriangulo();
            //sequenciaLogica();
            //media2();
            //positivosMedia();
            // preechimentovetor1();
            //trigoTabuleiro();
            // encaixe();
            media3();

        }
        public static void media3()
        {
            float a, b, c, d, avg;
            string[] values = Console.ReadLine().Split(' ');
            a = float.Parse(values[0]);
            b = float.Parse(values[1]);
            c = float.Parse(values[2]);
            d = float.Parse(values[3]);
            avg = ((a * 2 + b * 3 + c * 4 + d * 1) / 10);            
            Console.WriteLine("Media: " + Math.Round(avg,1).ToString("0.0"));
            if (avg >= (7.0))
            {
                Console.WriteLine("Aluno aprovado.");
            }
            if (avg < (5.0))
            {
                Console.WriteLine("Aluno reprovado.");
            }
            if (avg >= 5.0 &&  avg <= (6.9))
            {
                Console.WriteLine("Aluno em exame.");                
                float e = float.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + Math.Round(e,1).ToString("0.0"));
                avg = (e + avg) / 2;
                if (avg >= (5.0))
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                if (avg <= (4.9))
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: " + Math.Round(avg,1).ToString("0.0"));
            }

            Console.ReadKey();
        }
        public static void encaixe()
        {
            int qt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qt; i++)
            {
                string[] v = Console.ReadLine().Split(" ");
                string a = v[0];
                string b = v[1];

                if (a.EndsWith(b))
                    Console.WriteLine("encaixa");
                else
                    Console.WriteLine("nao encaixa");

            }
            Console.ReadKey();

        }
        public static void trigoTabuleiro()
        {

            int qtdTeste = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdTeste; i++)
            {

                double grao = double.Parse(Console.ReadLine());
                BigInteger value = (BigInteger)(Math.Pow(2, grao) / 12000);
                Console.WriteLine("{0} kg", value);
            }

            Console.ReadKey();
        }
        public static void preechimentovetor1()
        {
            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            n[0] = valorLido;
            int cont = 0;
            for (int i = 1; i < 10; i++)
            {
                n[i] = n[i - 1] * 2;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("N[" + cont + "]" + " = " + n[j]);
                cont++;
            }
            Console.ReadKey();

        }
        public static void positivosMedia()
        {
            float a, total = 0, avg = 0;
            int positive = 0;
            for (int i = 0; i < 6; i++)
            {
                a = float.Parse(Console.ReadLine());
                if (a > 0)
                {
                    positive++;
                    total = total + a;
                }
            }
            avg = total / positive;

            Console.WriteLine("{0} valores positivos", positive);
            Console.WriteLine("{0}", Math.Round(avg, 1));

            Console.ReadLine();
        }

        public static void media2()
        {
            double A, B, C, MEDIA;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            MEDIA = (((A * 2) + (B * 3) + (C * 5)) / 10);
            Console.WriteLine("MEDIA = " + MEDIA.ToString("0.0"));
            Console.ReadKey();

        }

        public static void sequenciaLogica()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + " " + (i * i) + " " + (i * i * i));
                Console.WriteLine(i + " " + ((i * i) + 1) + " " + ((i * i * i) + 1));
            }
            Console.ReadLine();
        }

        public static void TiposTriangulo()
        {
            string[] s = Console.ReadLine().Split(' ');
            Array.Sort(s);
            double C = double.Parse(s[0]);
            double B = double.Parse(s[1]);
            double A = double.Parse(s[2]);

            //continue a solucao
            if (A >= (B + C))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (A * A == (B * B + C * C))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (A * A > (B * B + C * C))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (A * A < (B * B + C * C))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if ((A == B) && (B == C) && (C == A))
                Console.WriteLine("TRIANGULO EQUILATERO");

            else if ((A == B) || (B == C))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
        public static void DivisaoEuclidiana()
        {
            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int q, r;

            q = a / b;
            r = a % b;
            if (r < 0)
            {
                double q1, r1 = 0.0;

                r1 = r + Math.Sqrt(b * b);
                q1 = (a - r1) / b;
                Console.WriteLine("{0} {1}", q1, r1);
            }
            else
            {
                Console.WriteLine("{0} {1}", q, r);
            }
            Console.ReadLine();
        }
        public static void Triangulo()
        {
            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if ((a + b > c) && (a + c > b) && (b + c > a)) //complete a condicional
            {
                Console.WriteLine("Perimetro = {0:0.0}", a + b + c); //complete a saida
            }
            else
            {
                Console.WriteLine("Area = {0:0.0}", ((a + b) * c) / 2); //complete a saida
            }
        }
        public static void ValidacaoNota()
        {
            double nota;
            int qtdIgual = 0;
            double soma = 0;
            while (qtdIgual != 2)
            {
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota > 0 && nota <= 10)   //complete a condicional
                {
                    soma += nota;
                    qtdIgual++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

            }
            Console.WriteLine("media = {0:0.00}", (soma / 2)); //insira a variavel correta
        }
        public static void Tuitando()
        {
            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            if (arr.Length <= 140) //complete a condicional
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");

        }

        public static void VisitaFeira()
        {

            int a, b, x;
            string[] aux = Console.ReadLine().Split(" ");
            a = int.Parse(aux[0]);
            b = int.Parse(aux[1]);

            x = a + b; //complete o código de acordo com o cálculo esperado

            Console.WriteLine("X = {0}", x);
        }
        public static void CardapioAerio()
        {
            string[] line = Console.ReadLine().Split(" ");
            string[] line2 = Console.ReadLine().Split(" ");
            int total = 0;

            for (int i = 0; i < line.Length; i++)
            {

                if (int.Parse(line[i]) - int.Parse(line2[i]) < 0)
                {
                    total = ((int.Parse(line[i]) - int.Parse(line2[i])) * -1) + total;

                }

            }
            Console.WriteLine(total);
        }
        public static void CoxinhaBueno()
        {
            string[] line = Console.ReadLine().Split(" ");
            double H = double.Parse(line[0]);
            double P = double.Parse(line[1]);
            var result = H / P;

            Console.WriteLine(result.ToString("0.00"));
        }
        public static void FormulaBhaskara()
        {
            double a, b, c, delta, r1, r2;
            string[] valor = Console.ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            //declare as demais variaveis

            delta = (Math.Pow(b, 2) - (4 * a * c));
            r1 = (-b + Math.Sqrt(delta)) / (2 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if ((a == 0) | (b * b - 4 * a * c < 0))
            {

                Console.WriteLine("Impossivel calcular");
            }
            else
            {

                Console.WriteLine("R1 = " + r1.ToString("0.00000"));
                Console.WriteLine("R2 = " + r2.ToString("0.00000"));
            }
        }

        public static void NotasMoedas()
        {
            double valor;
            int inteiro, auxNotas, auxMoedas;
            double auxMoedas2;

            valor = Convert.ToDouble(Console.ReadLine());

            inteiro = (int)valor;
            valor *= 100;
            auxMoedas = (int)valor;
            auxMoedas2 = valor;

            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro / 100);
            auxNotas = (inteiro % 100);

            Console.WriteLine("{0} nota(s) de R$ 50.00", auxNotas / 50);
            auxNotas = (auxNotas % 50);

            Console.WriteLine("{0} nota(s) de R$ 20.00", auxNotas / 20);
            auxNotas = (auxNotas % 20);

            Console.WriteLine("{0} nota(s) de R$ 10.00", auxNotas / 10);
            auxNotas = (auxNotas % 10);

            Console.WriteLine("{0} nota(s) de R$ 5.00", auxNotas / 5);
            auxNotas = (auxNotas % 5);

            Console.WriteLine("{0} nota(s) de R$ 2.00", auxNotas / 2);
            auxNotas = (auxNotas % 2);
            //complete o código

            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);
            auxMoedas %= 100;

            Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas / 50);
            auxMoedas %= (50);

            Console.WriteLine("{0} moeda(s) de R$ 0.25", auxMoedas / 25);
            auxMoedas %= (25);

            Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 10);
            auxMoedas %= (10);

            Console.WriteLine("{0} moeda(s) de R$ 0.05", auxMoedas / 05);
            auxMoedas %= (05);

            Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas / 01);
            auxMoedas %= (01);
            //complete o codigo
            Console.ReadLine();
        }
        public static void converterTempo()
        {
            var timeInSeconds = int.Parse(Console.ReadLine());

            var hours = timeInSeconds / 3600;
            // timeInSeconds =timeInSeconds/60;
            var minutes = (timeInSeconds - (hours * 3600)) / 60;
            double seconds = timeInSeconds - ((hours * 3600) + (minutes * 60));

            Console.WriteLine($"{hours}:{minutes}:{seconds}", hours, minutes, seconds);


        }
        public static void UltrapassarV()
        {
            var R = int.Parse(Console.ReadLine());
            var V = 0;
            var b = 0;
            var c = 0;
            while (V <= R)
            {
                V = int.Parse(Console.ReadLine());

            }

            while (b <= V)
            {
                b += R;
                c++;
                R++;
            }


            Console.WriteLine(c);
            Console.ReadLine();

        }

        public static void DataPizza()
        {
            string[] line = Console.ReadLine().Split(" ");
            int totalDePessoas = int.Parse(line[0]);
            int totalDeDatas = int.Parse(line[1]);

            string dataConsiderada = " ";

            for (int i = 0; i < totalDeDatas; i++)
            {
                int totalDePessoasQuePodemComparecer = 0;

                string[] entradaDataConfirmacao = Console.ReadLine().Split(" ");
                dataConsiderada = entradaDataConfirmacao[0];

                for (int j = 1; j < entradaDataConfirmacao.Length; j++)
                {
                    if (int.Parse(entradaDataConfirmacao[j]) == 1)
                    {
                        totalDePessoasQuePodemComparecer++;
                    }
                }

                if (totalDePessoasQuePodemComparecer == totalDePessoas)
                {
                    Console.WriteLine(dataConsiderada);
                    break;
                }
                else if (i + 1 >= totalDeDatas)
                {
                    Console.WriteLine("Pizza antes de FdA");
                }
            }
        }
        public static void Multiplos()
        {
            int suavariavel = int.Parse(Console.ReadLine());
            int multiplos2 = 0, multiplos3 = 0, multiplos4 = 0, multiplos5 = 0;
            //declare suas variaveis aqui   

            string[] n = Console.ReadLine().Split();

            //continue a solução
            for (int i = 0; i <= suavariavel - 1; i++)
            {

                if (int.Parse(n[i]) % 2 == 0)
                {
                    multiplos2++;
                }
                if (int.Parse(n[i]) % 3 == 0)
                {
                    multiplos3++;
                }
                if (int.Parse(n[i]) % 4 == 0)
                {
                    multiplos4++;
                }
                if (int.Parse(n[i]) % 5 == 0)
                {
                    multiplos5++;
                }
            }
            Console.WriteLine("{0} Multiplo(s) de 2", multiplos2);
            Console.WriteLine("{0} Multiplo(s) de 3", multiplos3);
            Console.WriteLine("{0} Multiplo(s) de 4", multiplos4);
            Console.WriteLine("{0} Multiplo(s) de 5", multiplos5);
        }
        public static void ComprasSupermercado()
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            // Implemente a solução aqui
            string[] vet = null;
            // string[] vet2 = null;
            // string[] vet3 = null;
            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                vet = Console.ReadLine().Split();
                var meuHashSetVet = new HashSet<string>(vet.OrderBy(x => x));
                foreach (var item in meuHashSetVet)
                {


                    Console.Write(item + " ");
                }
                Console.WriteLine("");

            }
        }
        public static void Coordenadas()
        {
            double x, y;
            string[] vet = Console.ReadLine().Split();
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);


            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
        public static void Inverter()
        {
            string n = Console.ReadLine();
            //continue a solução
            char[] arrayChar = n.ToCharArray();
            Array.Reverse(arrayChar);

            Console.WriteLine(arrayChar);
            Console.ReadLine();
        }
        public static void TempoEvento()
        {
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
        public static void Bazinga()
        {

            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
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
