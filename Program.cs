using System;

namespace CambioDeMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] moneda = { 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1 };
            int n = moneda.Length;
            int[] veces = new int[n];
            double monto = 999.99;

            while(monto != 0)
            {
                Console.WriteLine("MONTO: ");
                monto = Double.Parse(Console.ReadLine());
                if(monto == 0)
                {
                    Environment.Exit(0);
                }
                for(int i=0; i<n; i++)
                {
                    while(monto >= moneda[i])
                    {
                        veces[i]++;
                        monto -= moneda[i];
                    }
                }

                for(int i=0; i<n; i++)
                {
                    if (veces[i] > 0)
                    {
                        Console.Write("\t" + veces [i] + "\t");
                        if(moneda[i] < 10)
                        {
                            Console.Write(" Moneda(s) de ");
                        }
                        else
                        {
                            Console.Write(" Billete(s) de ");
                        }
                        Console.WriteLine(moneda[i]);
                    }
                }
                
            }

        }
    }
}