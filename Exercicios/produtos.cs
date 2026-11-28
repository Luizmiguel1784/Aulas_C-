using System;

public class Program
{
    public static void Main()
    {
        double[] num = new double[5];

        double maior = double.MinValue;
        double menor = double.MaxValue;
        
        
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine("Digite o nome do produto e o valor");
            num[i] = double.Parse(Console.ReadLine());


            if (maior < num[i])
            {
                maior = num[i];

            }
            if (menor > num[i])
            {
                menor = num[i];
            }
        }
        Console.WriteLine($"O maior numero é {maior} o menor é: {menor}");

    }
}