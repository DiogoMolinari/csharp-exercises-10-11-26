/*Exercício 3: Faça um programa que leia um número inteiro e mostre primeiramente só os valores ímpares,
de forma crescente e depois os valores pares, de forma decrescente. O número digitado é a condição de parada.*/

int number = 0;

Console.Write("Escolha um número inteiro como critério de parada: ");
number = int.Parse(Console.ReadLine());

Console.WriteLine("Números ímpares em ordem crescente: ");
for (int i = 1;  i <= number; i++)
{
       if (i % 2 != 0)
        Console.WriteLine(i);
}

Console.WriteLine("Números pares em ordem decrescente: ");
for(int j = number; j >= 0; j--)
{
       if (j % 2 == 0)
        Console.WriteLine(j);
}