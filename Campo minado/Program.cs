using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campo_minado;

namespace Campo_minado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis iniciais
            int casaAux = 0;
            int linhaAux = 1;


            Console.WriteLine("Digite um valor de 1 a 10: ");
            int linha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor de 1 a 10: ");
            int coluna = int.Parse(Console.ReadLine());


            List<Mina> list = new List<Mina>();
            for (int j = 1; j <= linha; j++)
            {
                for (int i = 1; i <= coluna; i++)
                {
                    string casa = Convert.ToString(j) + Convert.ToString(i);
                    list.AddRange(new List<Mina>
                {
                        new Mina(casa, '-', false, false),
                });
                }
                Console.WriteLine();
            }
            Console.Clear();

            //Imprimir linhas Superiores
            Console.Write($"     ");
            for (int i = 1; i <= coluna; i++)
            {
                if (i<10)
                    Console.Write($" {i} ");
                else
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write($"     ");
            for (int i = 1; i <= coluna; i++)
            {
                Console.Write($" | ");
            }

            //Imprimir demais linhas
            Console.WriteLine();
            Console.Write($" {linhaAux} - ");
            linhaAux++;
            foreach (var casa in list)
            {
                casaAux++;
                Console.Write($" {casa.Valor} ");
                if (casaAux == coluna)
                    if (casaAux == coluna)
                    {
                        Console.WriteLine();
                        if (linhaAux < 10)
                            Console.Write($" {linhaAux} - ");
                        else
                            if (linhaAux < coluna+1)
                                Console.Write($"{linhaAux} - ");
                        linhaAux++;
                        casaAux = 0;
                    }
            }
            Console.ReadLine();
        }
    }
}
