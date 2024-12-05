/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

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
        Console.WriteLine("Digite um valor em reais: ");  
        float valor = float.Parse(Console.ReadLine());  

        
        int valorCentavos = (int)(valor * 100);  
        
 
        int[] notas = { 10000, 5000, 2000, 1000, 500, 100 };  
        int[] quantidadeNotas = new int[notas.Length];  

        for (int i = 0; i < notas.Length; i++)  
        {  
            if (valorCentavos >= notas[i])  
            {  
                quantidadeNotas[i] = valorCentavos / notas[i];  
                valorCentavos %= notas[i];   
            }  
        }  

    
        Console.WriteLine("Quantidade mínima de notas:");  
        for (int i = 0; i < notas.Length; i++)  
        {  
            if (quantidadeNotas[i] > 0)  
            {  
                Console.WriteLine($"Notas de R${notas[i] / 100.0}: {quantidadeNotas[i]}");  
            }  
        }  
    }  
}