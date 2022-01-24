using System;

namespace InstrucaoIfElseAlinhada
{
    class Program
    {
        static void Main(string[] args)
        {
            float media = 2.6f;
            bool aprovado = media >= 6;
            bool recuperacao = media >=5;

            if(aprovado)
            {
                System.Console.WriteLine("Aluno Aprovado!");
            }
            else if(recuperacao)
            {
                System.Console.WriteLine("Aluno em Recuperacao!");
            }
            else
            {
                System.Console.WriteLine("Aluno Reprovado!");
            }
        }
    }
}
