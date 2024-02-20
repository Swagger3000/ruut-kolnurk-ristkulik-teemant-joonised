namespace ConsoleApp1
{
    using System;
    using System.Runtime.Intrinsics.X86;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Millist kujundit soovid?\nRuut, teemant, ristkylik, kolmnurk...");
            string valik = Console.ReadLine().ToLower();

            switch (valik)
            {
                case "ruut":
                    RuuduInfo();
                    break;
                case "teemant":
                    TeemandiInfo();
                    break;
                case "ristkylik":
                    RistkylikuInfo();
                    break;
                case "kolmnurk":
                    KolmnurgaInfo();
                    break;
                default:
                    Console.WriteLine("Sellist kujundit ei ole valikus.");
                    break;
            }
        }

        static void RuuduInfo()
        {
            Console.WriteLine("Sisesta ruudu külje pikkus:");
            int kylg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ruut:");
            for (int i = 0; i < kylg; i++)
            {
                for (int j = 0; j < kylg; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            int umbermoot = 4 * kylg;
            int pindala = kylg * kylg;
            Console.WriteLine($"Ruudu ümbermõõt on {umbermoot} ja pindala on {pindala} ühikut.");
        }

        static void TeemandiInfo()
        {
            Console.WriteLine("Sisesta teemanti diagonaalide pikkused (vaheldumisi):");
            int diag1 = Convert.ToInt32(Console.ReadLine());
            int diag2 = Convert.ToInt32(Console.ReadLine());

            int poolDiag1 = diag1 / 2;
            int poolDiag2 = diag2 / 2;

            Console.WriteLine("Teemant:");

            for (int i = 0; i <= diag1 / 2; i++)
            {
                for (int j = 0; j <= diag1 / 2 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            for (int i = diag1 / 2 - 1; i >= 0; i--)
            {
                for (int j = 0; j <= diag1 / 2 - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            int umbermoot = 2 * (diag1 + diag2);
            int pindala = (diag1 * diag2) / 2;
            Console.WriteLine($"Teemandi ümbermõõt on {umbermoot} ja pindala on {pindala} ühikut.");
        }

        static void RistkylikuInfo()
        {
            Console.WriteLine("Sisesta ristküliku pikkus ja laius:");
            int pikkus = Convert.ToInt32(Console.ReadLine());
            int laius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ristkülik:");

            for (int i = 0; i < laius; i++)
            {
                for (int j = 0; j < pikkus; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            int umbermoot = 2 * (pikkus + laius);
            int pindala = pikkus * laius;
            Console.WriteLine($"Ristküliku ümbermõõt on {umbermoot} ja pindala on {pindala} ühikut.");
        }

        static void KolmnurgaInfo()
        {
            Console.WriteLine("Sisesta kolmnurga alus ja kõrgus:");
            int alus = Convert.ToInt32(Console.ReadLine());
            int korgus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kolmnurk:");

            for (int i = 0; i < korgus; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            int umbermoot = alus + 2 * (int)Math.Sqrt(Math.Pow(alus / 2, 2) + Math.Pow(korgus, 2));
            double pindala = (alus * korgus) / 2.0;
            Console.WriteLine($"Kolmnurga ümbermõõt on {umbermoot} ja pindala on {pindala} ühikut.");
        }
    }
}