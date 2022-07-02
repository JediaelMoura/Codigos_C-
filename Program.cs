using System;
using static System.Console;

public class Nome_Idade
{
   static void Main()
    {
        Console.WriteLine("Olá, por favor, qual é o seu nome?");
        string nome = Console.ReadLine();   // Vai aguardar a digitação do usuário.	 
        Console.WriteLine("Olá " + nome + " seja bem vindo!\n");

        Console.WriteLine(nome + ", e qual é a sua profissão?");
        string profissao = Console.ReadLine();
        Console.WriteLine("Que legal " + nome + ", você é " + profissao + "!\n");

        Console.WriteLine(nome + ", você gosta de ser " + profissao + "?");
        string resposta = Console.ReadLine();
        Console.WriteLine(resposta + "... top D+, adorei conversar com você.\n");
        Console.WriteLine("bye bye...");
    }
}