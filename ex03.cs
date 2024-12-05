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
class exercicio03 {
  static void Main() {
      
      string ddd = "";
      
      Console.WriteLine("Digite seu DDD: ");
      ddd = Console.ReadLine();
      
      if(ddd == "61"){
        Console.WriteLine("Brasilia");
      
      }
      
      else if(ddd == "71"){
          Console.WriteLine("Salvador");
        
      }
      
       else if(ddd == "11"){
          Console.WriteLine("São Paulo");
      }
      
       else if(ddd == "21"){
          Console.WriteLine("Rio de Janeiro");
      }
      
       else if(ddd == "32"){
          Console.WriteLine("Juiz de Fora");
      }
      
        else if(ddd == "19"){
          Console.WriteLine("Campinas");
      }
      
      else if(ddd == "27"){
          
          Console.WriteLine("Vitoria");
          
      }
      
        else if(ddd == "31"){
          Console.WriteLine("Belo Horizonte");
      }
        else 
        Console.WriteLine("DDD não encontrado!!");
  }
}