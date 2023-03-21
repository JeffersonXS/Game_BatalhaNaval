using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Naval
{
    class Program
    {
        static void Main(string[] args)
        {
            bool AcabarJogo;
            string[,] Matriz = new string[11, 11];
            int col;
            int lin;
            int JogaLinha;
            int JogaColuna;
            string text;
            int navio;
            int boia;
            int destroier;
            int sub;

            Console.WriteLine("                  Batalha Naval              ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  Encontre Navios, Boias, Submarinos, Destroier  ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    PARA DESISTIR: Pressione duas vez o 'ESC'     ");
            Console.WriteLine();
            Console.WriteLine();

            for (lin = 1; lin <= 10; lin += 1)
			{
                for (col = 1; col <= 10; col += 1)
				{
                    Matriz [lin, col] = "A";
				}
			}

            Random rnd = new Random();

            for (navio = 1; navio <= 4; navio += 1)
            {
                lin = rnd.Next(0, 9);
                col = rnd.Next(0, 9);
                 if (lin == 0)
				{
                    lin++;
				}
                 if (col == 0)
				{
                    col++;
				}
                Matriz[lin, col] = "N";
            }

            for (boia = 1; boia <= 4; boia += 1)
            {
                lin = rnd.Next(0, 9);
                col = rnd.Next(0, 9);
                if (lin == 0)
                {
                    lin++;
                }
                if (col == 0)
                {
                    col++;
                }
                Matriz[lin, col] = "B";
            }

            for (destroier = 1; destroier <= 2; destroier += 1)
            {
                lin = rnd.Next(0, 9);
                col = rnd.Next(0, 9);
                if (lin == 0)
                {
                    lin++;
                }
                if (col == 0)
                {
                    col++;
                }
                Matriz[lin, col] = "D";
            }

            for (sub = 1; sub <= 2; sub += 1)
            {
                lin = rnd.Next(0, 9);
                col = rnd.Next(0, 9);
                if (lin == 0)
                {
                    lin++;
                }
                if (col == 0)
                {
                    col++;
                }
                Matriz[lin, col] = "S";
            }

                Console.WriteLine();
                Console.WriteLine("             QUE COMECE A BATALHA!!!            ");
                Console.WriteLine();

            AcabarJogo = false;
            while (AcabarJogo == false)
			{
                Console.WriteLine();
                Console.WriteLine("     Digite o valor de uma linha (1-10): ");
                text = Console.ReadLine();
                JogaLinha = int.Parse(text);
                Console.WriteLine();
                Console.WriteLine("     Digite o valor de uma coluna (1-10): ");
                text = Console.ReadLine();
                JogaColuna = int.Parse(text);
                if ((JogaLinha == 0) && (JogaColuna == 0))
				{
                    AcabarJogo = true;
				}
                else if ((JogaLinha >= 1) && (JogaLinha <= 10) && (JogaColuna >= 1) && (JogaColuna <= 10))
				{
                    if (Matriz[JogaLinha, JogaColuna] == "A")
					{
                        Console.WriteLine("              Splash              ");
                        Console.WriteLine();
					}
                    if (Matriz[JogaLinha, JogaColuna] == "N")
					{
                        Console.WriteLine("              Navio              ");
                        Console.WriteLine();
                    }
                    if (Matriz[JogaLinha, JogaColuna] == "B")
                    {
                        Console.WriteLine("              Boia              ");
                        Console.WriteLine();
                    }
                    if (Matriz[JogaLinha, JogaColuna] == "D")
                    {
                        Console.WriteLine("            Destroier            ");
                        Console.WriteLine();
                    }
                    if (Matriz[JogaLinha, JogaColuna] == "S")
                    {
                        Console.WriteLine("            Submarino              ");
                        Console.WriteLine();
                    }
                    Matriz[JogaLinha, JogaColuna] = "J";
                }
            }
        }
    }
}