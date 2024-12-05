/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite uma frase para contar o número de palavras:");

        string frase = Console.ReadLine();

        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int numeroDePalavras = palavras.Length;

        Console.WriteLine($"A frase contém {numeroDePalavras} palavras.");
    }
}
