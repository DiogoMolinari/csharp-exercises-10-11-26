// loop while
int accountant = 10;

while (accountant > 0)
{
    Console.WriteLine(accountant);
    accountant--;
    Thread.Sleep(1000);
}
Console.WriteLine("Happy New Year!");


// loop do while
accountant = 10;
do
{
    Console.WriteLine(accountant);
    accountant--;
    Thread.Sleep(1000);

} while (accountant > 0);
Console.WriteLine("Happy New Year!");


// loop for
for (accountant = 10; accountant > 0; accountant--)
{
    Console.WriteLine(accountant);
    Thread.Sleep(1000);
}
Console.WriteLine("Happy New Year!");