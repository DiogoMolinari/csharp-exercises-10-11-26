//Exercício 1: Faça um programa que leia um número inteiro e mostre a tabuada de 1 a 10.

int number = 0;

Console.WriteLine("Digite aqui o número que deseja calcular a tabuada:");
number = int.Parse(Console.ReadLine());

int accountant = 1;
for (accountant = 1; accountant <= 10; accountant++)
{
    Console.WriteLine(number + " x " + accountant + " = " + number * accountant);
}
