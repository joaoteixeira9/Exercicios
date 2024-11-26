using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero
            //Console.WriteLine("POSITIVO, NEGATIVO OU ZER0");
            //int num = 0;
            //Console.Write("Informe um número: ");
            //num = int.Parse(Console.ReadLine());

            //if (num == 0)
            //{
            //    Console.WriteLine("O número " + num + " é zero.");
            //}
            //else if (num > 0)
            //{
            //    Console.WriteLine("O número " + num + " é positivo.");
            //}
            //else if (num < 0)
            //{
            //    Console.WriteLine("O número " + num + " é negativo.");
            //}
            //else
            //{
            //    Console.WriteLine("Número inválido!");
            //}

            //// 2 - Escreva um programa que leia um mês do ano e informe quantos dias ele tem.
            //Console.WriteLine("MÊS E SEUS DIAS");
            //int mes = 0;
            //Console.Write("Escolha um mês: ");
            //mes = int.Parse(Console.ReadLine());

            //if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            //{
            //    Console.WriteLine("O mês tem 31 dias.");
            //}
            //else if (mes == 2 || mes == 4 || mes == 6 || mes == 9 || mes == 11)
            //{
            //    Console.WriteLine("O mês tem 30 dias.");
            //}
            //else
            //{
            //    Console.WriteLine("Número inválido.");
            //}

            //// 3 - Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7)
            //// ou reprovado (nota menor que 5)
            //Console.WriteLine("APROVAÇÃO DE ALUNO");
            //int nota = 0;
            //Console.Write("Informe a nota de fulano: ");
            //nota = int.Parse(Console.ReadLine());

            //if (nota >= 7)
            //{
            //    Console.WriteLine("Fulano está aprovado!");
            //}
            //else if (nota == 5 || nota == 6)
            //{
            //    Console.WriteLine("Fulano está de recuperação.");
            //}
            //else
            //{
            //    Console.WriteLine("Fulano está retido!");
            //}

            //// 4 - Calcule a soma de todos os números de 1 a 100 utilizando um laço de repetição. //5050
            //Console.WriteLine("SOMA DE 1 A 100");
            //int numero = 1;
            //int numero1 = 0;
            //while (numero <= 100)
            //{
            //    numero1 = numero + numero1;
            //    numero++;
            //}
            //Console.WriteLine(numero1);

            //// 5 - Implemente uma contagem regressiva de 10 até 0 utilizando um laço de repetição.
            //Console.WriteLine("CONTAGEM REGRESSIVA");
            //int contador = 10;
            //while (contador > 0)
            //{
            //    Console.WriteLine(contador);
            //    contador--;
            //}

            //// 6 - Faça um programa que leia o nome de um aluno e suas três notas, calcule a média e
            //// informe se ele está aprovado (média maior ou igual a 7) ou reprovado. 
            //Console.WriteLine("APROVAÇÃO DE ALUNO 2.0");
            //int nota1 = 0;
            //int nota2 = 0;
            //int nota3 = 0;

            //Console.Write("Informe a 1 nota do fulano: ");
            //nota1 = int.Parse(Console.ReadLine());
            //Console.Write("Informe a 2 nota do fulano: ");
            //nota2 = int.Parse(Console.ReadLine());
            //Console.Write("Informe a 3 nota do fulano: ");
            //nota3 = int.Parse(Console.ReadLine());

            //int media = (nota1 + nota2 + nota3) / 3;

            //Console.WriteLine("A média do fulano é: " + media);

            //if (media >= 7)
            //{
            //    Console.WriteLine("Fulano está aprovado!");
            //}
            //else
            //{
            //    Console.WriteLine("Fulano está reprovado!");
            //}

            // 7 - Faça um programa que peça ao usuário para digitar um ano e verifique se é bissexto 

            //int ano = 0;
            //Console.Write("Informe um ano: ");
            //ano = int.Parse(Console.ReadLine());

            //if (ano %4 == 0)
            //{
            //    Console.WriteLine("Este ano é bissexto");
            //}
            //else
            //{
            //    Console.WriteLine("Este ano não é bissexto");
            //}

            // 8 - Implemente um jogo de adivinhação onde um usuário tem que adivinhar um número de 1 e 10. O programa deve dar dicas de "maior" ou 
            //"menor" após cada tentativa, utilizando um laço de repetição.

            Random rd = new Random();
            int sorteador = rd.Next(1,100);
            int tentativa = 0;
            Console.WriteLine(sorteador);
            Console.Write("Informe um número: ");
            tentativa = int.Parse(Console.ReadLine());
            while(tentativa != sorteador)
            {
                if (tentativa == sorteador)
                {
                    Console.WriteLine("Você acertou o número!");
                }
                else if (tentativa > sorteador)
                {
                    Console.WriteLine("Chute um número mais baixo: ");
                }
                else
                {
                    Console.WriteLine("Chute um número mais alto: ");
                }
            }
        }

    }
}
