using System;
					
public class Program
{
	public static void Main()
	{
    int value = 10;
    while (qtd > 0){
        Console.WriteLine($"Lançamento em {qtd}");
        
        qtd--;
    }    
    Console.WriteLine("Lançou");
    
  
    
    int value = 0;
    while (value <= 100){
        Console.WriteLine($"{value}");
        
        value += 2;
    }    
    Console.WriteLine("Esses são os numeros pares de 0 a 100");
    
		double deposito = 0.0;
		double value = 0.0;
		int contador = 0;
		while( value <= 500.00){
		
			if(deposito < 0){
				Console.WriteLine("Valor invalido, Tente Novamente");
			}
			Console.WriteLine("faça um deposito");
			deposito = double.Parse(Console.ReadLine());
			
			value = value + deposito;
			Console.WriteLine($"Seu saldo é de: {value}");
		
			contador++;
		}
  		Console.WriteLine($"Seu saldo agora é de {value} Obrigado por usar!, Foram feitos {contador}");


        	 double total = 0.0, valor = 0.0;	
	 
		while(true){
	 
		 Console.WriteLine("Digite o valor");
		 valor = double.Parse(Console.ReadLine());
	 	 
			if(valor == 0.0) break;
			
			total = total + valor;
		}
		Console.WriteLine($"o Total ={total}");


    }
}