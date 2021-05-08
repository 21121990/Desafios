using System;

namespace desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            CrescimentoPopulacional();
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

    }

}
