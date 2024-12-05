/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
       
        string formato = "dd/MM/yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;

        Console.Write("Digite a primeira data (dd/MM/yyyy): ");
        string data1Input = Console.ReadLine();
        DateTime data1 = DateTime.ParseExact(data1Input, formato, provider);

        Console.Write("Digite a segunda data (dd/MM/yyyy): ");
        string data2Input = Console.ReadLine();
        DateTime data2 = DateTime.ParseExact(data2Input, formato, provider);

        TimeSpan diferenca = data2 - data1;

        Console.WriteLine($"A quantidade de dias entre {data1:dd/MM/yyyy} e {data2:dd/MM/yyyy} é {diferenca.Days} dia(s).");
    }
}