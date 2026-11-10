/*Exercício 5: Faça um programa que leia um número inteiro e exiba
o seu cálculo fatorial, retornando o seu resultado.*/


int number = 0;
long factorial = 1;

Console.Write("Digite um número inteiro para calcular o fatorial: ");
number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    factorial = factorial * i;
}

Console.WriteLine("O resultado de fatorial de " + number + " é: " + factorial);

