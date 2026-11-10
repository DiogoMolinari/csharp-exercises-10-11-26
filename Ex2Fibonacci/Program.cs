/*Exercício 2: Faça um programa que leia um número inteiro. Esse número é a posição até
 onde a sequência Fibonacci será exibida.*/

long number = 0;
long a = 0;
long b = 1;
long result = 0;


Console.Write("Escreva um número inteiro para ser a última posição de Fibonacci: ");
number = long.Parse(Console.ReadLine());

for(int i = 0; i<= number; i++)
{
    result = a + b;
    Console.WriteLine(a + " + " + b + " = " + result);

    a = b;
    b = result;
}

