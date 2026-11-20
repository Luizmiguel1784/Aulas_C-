using System;
class HelloWorld
{
    static void Main()
    {
        double a, b, c, total, salario;
        int mes, n, n1, n2, n3, n4, n5;


        Console.WriteLine("Exercicio 1");
        Console.WriteLine("===========================================================");
        Console.WriteLine("Quais foram as notas");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        total = (a + b + c) / 3;

        if (total >= 5)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }

        Console.WriteLine("Exercicio 2");

        Console.WriteLine("Digite seu salario");
        salario = double.Parse(Console.ReadLine());

        if (salario <= 1000.00)
        {
            Console.WriteLine($"Seu salario agora é: {salario + salario * 0.25}, Seu aumento foi de: {salario * 0.25}");

        }
        else if (1000.00 <= salario && salario < 2000.00)
        {
            Console.WriteLine($"Seu salario agora é: {salario + salario * 0.15}, Seu aumento foi de: {salario * 0.15}");
        }

        else
        {
            Console.WriteLine($"Seu salario agora é: {salario + salario * 0.10}, Seu aumento foi de: {salario * 0.10}");

        }

        Console.WriteLine("Digite o mês");
        mes = int.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("Janeiro");
                break;

            case 2:
                Console.WriteLine("Fevereiro");
                break;

            case 3:
                Console.WriteLine("Março");
                break;

            case 4:
                Console.WriteLine("Abril");
                break;

            case 5:
                Console.WriteLine("Maio");
                break;

            case 6:
                Console.WriteLine("Junho");
                break;

            case 7:
                Console.WriteLine("Julho");
                break;

            case 8:
                Console.WriteLine("Agosto");
                break;

            case 9:
                Console.WriteLine("Setembro");
                break;

            case 10:
                Console.WriteLine("Outubro");
                break;

            case 11:
                Console.WriteLine("Novembro");
                break;

            case 12:
                Console.WriteLine("Dezembro");
                break;

            default:
                Console.WriteLine("Esse mês não existe");
            break;
        }

        Console.WriteLine("Digite um valor");
        n = int.Parse(Console.ReadLine());

        if (n > 3)
        {
            Console.WriteLine("Valor invalido");
        }
        else
        {
            Console.WriteLine($"Valor Valido{n}");
        }


        Console.WriteLine("Digite um numero");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero");
        n4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero");
        n5 = int.Parse(Console.ReadLine());

        if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
        {
            if (n2 < n3 && n2 < n4 && n2 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n1} e o segundo é o menor {n2}");

            }
            else if (n3 < n4 && n3 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n1} e o segundo é o menor {n3}");


            }
            else if (n4 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n1} e o segundo é o menor {n4}");


            }
            else
            {
                Console.WriteLine($"O Primeiro numero é o maior {n1} e o segundo é o menor {n5}");

            }
        }
        if (n1 < n2 && n2 > n3 && n2 > n4 && n2 > n5)
        {
            if (n1 < n3 && n1 < n4 && n1 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n2} e o segundo é o menor {n1}");

            }
            else if (n3 < n4 && n3 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n2} e o segundo é o menor {n3}");


            }
            else if (n4 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n2} e o segundo é o menor {n4}");


            }
            else
            {
                Console.WriteLine($"O Primeiro numero é o maior {n2} e o segundo é o menor {n5}");

            }
        }
        if (n3 > n2 && n1 < n3 && n1 > n3 && n3 > n5)
        {
            if (n2 < n1 && n1 < n4 && n1 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n3} e o segundo é o menor {n1}");

            }
            else if (n2 < n4 && n2 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n3} e o segundo é o menor {n2}");


            }
            else if (n4 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n3} e o segundo é o menor {n4}");


            }
            else
            {
                Console.WriteLine($"O Primeiro numero é o maior {n3} e o segundo é o menor {n5}");

            }
        }
        if (n4 > n2 && n4 > n3 && n1 > n4 && n4 > n5)
        {
            if (n2 < n1 && n1 < n3 && n1 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n4} e o segundo é o menor {n1}");

            }
            else if (n2 < n3 && n2 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n4} e o segundo é o menor {n2}");


            }
            else if (n3 < n5)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n4} e o segundo é o menor {n3}");


            }
            else
            {
                Console.WriteLine($"O Primeiro numero é o maior {n4} e o segundo é o menor {n5}");

            }

        }
        if (n5 > n1 && n5 > n2 && n5 > n4 && n4 < n5)
        {
            if (n2 < n1 && n1 < n3 && n1 < n4)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n5} e o segundo é o menor {n1}");

            }
            else if (n2 < n3 && n2 < n4)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n5} e o segundo é o menor {n2}");


            }
            else if (n3 < n4)
            {
                Console.WriteLine($"O Primeiro numero é o maior {n5} e o segundo é o menor {n3}");


            }
            else
            {
                Console.WriteLine($"O Primeiro numero é o maior {n5} e o segundo é o menor {n4}");

            }
            
        }

        Console.WriteLine("Digite um numero");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um numero");
        n2 = int.Parse(Console.ReadLine());
        
        

        if (n1 > n2)
        {
            Console.WriteLine($"O maior valor é {n1} e a diferença é: {n1 - n2}");
        }
        else if (n2 > n1)
        {
            Console.WriteLine($"O maior valor é {n2} e a diferença é: {n2 - n1}");
            
        }

        else
        {
            Console.WriteLine("Os valores são iguais");
        }
    
    }

}