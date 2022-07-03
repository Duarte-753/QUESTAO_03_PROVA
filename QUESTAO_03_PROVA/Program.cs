using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_03_PROVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nome:julio Duarte Batista RA:6322046 


            /*3 – Criar um programa para calcular e mostrar a área de 3 figuras geométricas diferentes,
             * não vale quadrado e nem retângulo.

            Observação: as figuras são de escolha livre, dá um Google se não lembrar como faz o cálculo de alguma delas.

            Requisitos: Deve ser apresentada uma lista para o usuário com o nome das 3 figuras que ele pode escolher para calcular.
            Deve-se utilizar Switch Case. */

            double area, b, h, B, d, D, figura;

            Console.WriteLine("Segue abaixo, o código corresponde da figura geométrica que deseja utilizar: \n\n1-Triângulo\n2-Trapézio\n3-Losângulo");
            Console.Write("\nDigite o código da figura escolhida: ");
            figura = Convert.ToDouble(Console.ReadLine());

            switch (figura)
            {
                case 1:
                Console.WriteLine("Qual a base(b): ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual a altura(h): ");
                h = Convert.ToDouble(Console.ReadLine());

                area = (b * h) / 2;

                Console.WriteLine("A área do Triâgulo é: " + area + " m²");
                    break;
                case 2:
            
            
            
                Console.WriteLine("Qual a base menor(b): ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual a base maior(B): ");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual a altura(h): ");
                h = Convert.ToDouble(Console.ReadLine());

                area = ((B + b)*h)/ 2;

                Console.WriteLine("A área do Trapézio é: " + area + " m²");
                    break ;
            
                case 3:
            
                Console.WriteLine("Qual a diâmetro menor(d): ");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual a diâmetro maior(D): ");
                D = Convert.ToDouble(Console.ReadLine());
                

                area = (D*d) / 2;

                Console.WriteLine("A área do Losângulo é: " + area + " m²");
                    break;
            }

            Console.ReadKey();


        }
    }
}
