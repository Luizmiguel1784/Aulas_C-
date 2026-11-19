using System;
					
public class Program
{
	public static void Main()
	{
		string cidade,produto,nome;
		int quantidade,idade;
		double preco,n1,n2,n3,p1,p2,p3,salario,b,a,r,p;
		double PI = 3.1415;
		/*
			
		Console.WriteLine("Exercício 1");
		
		Console.WriteLine("Digite o seu nome");
		nome = Console.ReadLine();
		
		Console.WriteLine("Digite sua idade");
		idade = int.Parse((Console.ReadLine()));
						  
		Console.WriteLine("Digite sua cidade");
		cidade = Console.ReadLine();
		
		Console.WriteLine($"Seu nome é: {nome}, sua idade é: {idade}, sua cidade é: {cidade}");
		
		Console.WriteLine("===============================================================");
		Console.WriteLine("Exercício 2");
		
		
		Console.WriteLine("Qual sua idade hoje?");
		idade = int.Parse((Console.ReadLine()));
		
		
		Console.WriteLine($"Você tem: {idade}, e você terá {idade + 5} daqui a cinco anos");

		Console.WriteLine("===============================================================");
		Console.WriteLine("Exercício 3");
		
		Console.WriteLine("Qual o nome do produto");
		produto = Console.ReadLine();
		
		Console.WriteLine("Qual o valor");
		preco = double.Parse(Console.ReadLine());

		Console.WriteLine("Qual a quantidade que você comprou");
		quantidade = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"Você comprou {quantidade}, {produto}, o preço unitário {preco}, o valor total é {quantidade * preco} ");
							  
		Console.WriteLine("===============================================================");
		Console.WriteLine("Exercício 4");
		
		Console.WriteLine("Quais foram as notas");
		n1 = double.Parse((Console.ReadLine()));
		n2 = double.Parse((Console.ReadLine()));
		n3 = double.Parse((Console.ReadLine()));
		Console.WriteLine($"A media foi {(n1+n2+n3)/3}");
		
		Console.WriteLine("===============================================================");
		Console.WriteLine("Exercício 5");
		Console.WriteLine("Quais foram as notas");
		n1 = double.Parse((Console.ReadLine()));
		n2 = double.Parse((Console.ReadLine()));
		n3 = double.Parse((Console.ReadLine()));
		Console.WriteLine("Qual o peso de cada");
		p1 = double.Parse((Console.ReadLine()));
		p2 = double.Parse((Console.ReadLine()));
		p3 = double.Parse((Console.ReadLine()));
		Console.WriteLine($"A media foi {((n1 * p1) + (n2 * p2) + (n3*p3) ) / (p1 + p2 + p3)}");
			
		Console.WriteLine("===============================================================");
		Console.WriteLine("Exercício 6-7");
		
		Console.WriteLine("Qual o seu salário antigo?");
		salario = double.Parse((Console.ReadLine()));
		Console.WriteLine($"O seu salario com reajuste é: {salario + salario * 0.25 } o valor do reajuste é: {salario * 0.25}");
			
		Console.WriteLine("===============================================================");
		Console.WriteLine("Exercício 8");
		
		Console.WriteLine("Qual a base e a altura do triangulo");
		a = double.Parse((Console.ReadLine()));
		b = double.Parse((Console.ReadLine()));
		
		Console.WriteLine($"A area do triangulo { b * a / 2}");
			
		Console.WriteLine("===============================================================");
		Console.WriteLine("Exercício 9");
		
		Console.WriteLine("Qual o raio do circulo");
		r = double.Parse((Console.ReadLine()));
		
		Console.WriteLine($"A area do circulo é: { PI * ( r * r ) }");
			
		Console.WriteLine("===============================================================");
		Console.WriteLine("Exercício 10");
		
		Console.WriteLine("Diga a medida em pés");
		p = double.Parse((Console.ReadLine()));	
		
		Console.WriteLine($"A medida em polegadas é: {p*12}, a medida em jardas é: {p/3}, a medida em milhas é: {p / 5280}");
		*/
		Console.WriteLine("===============================================================");
		Console.WriteLine("Desafio");
		
		int caixaA = 15;
		int caixaB = 30;
		int caixaC = 45;
		int caixaD = 0;
		double Total = 0;
		double media;
		int dif;
		
		Console.WriteLine($"Caixa A = {caixaA} Caixa B = {caixaB} Caixa C = {caixaC}");
		
		/*
		
		caixaA	45
		caixaB	15
		caixaC	30

		*/
		
		caixaD = caixaA;
		caixaA = caixaC;
		caixaC = caixaB;
		caixaB = caixaD;
		Console.WriteLine($"Caixa A = {caixaA} Caixa B = {caixaB} Caixa C = {caixaC}");
		
		caixaA = caixaA - 10 + 5;
		
		caixaB = (caixaB + 10 - 12);
		
		caixaC = (caixaC - 5 + 12);
		
		Console.WriteLine($"Caixa A = {caixaA} Caixa B = {caixaB} Caixa C = {caixaC}");
		
		Total = caixaA + caixaB + caixaC;
		
		media = Total/3;
		
		dif = caixaA - caixaB;
		
		p = 100/Total * caixaC ;
		
		Console.WriteLine($"Total = {Total}, Media = {media}, Diferença Caixa A para o Caixa B {dif}, Porcentagem da Caixa C = {p} ");
		
		caixaA = caixaA + 10 - 5;
		caixaB = (caixaB - 10 + 12);
		caixaC = (caixaC + 5 - 12);
			
		Console.WriteLine($"Caixa A = {caixaA} Caixa B = {caixaB} Caixa C = {caixaC}");
		
	}
}