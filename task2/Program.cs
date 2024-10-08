Console.WriteLine("vvedi naturalnoe trehzn chislo");
int num = Convert.ToInt32(Console.ReadLine());

int seconddigit = num / 10 % 10;
int thirddigit = num % 10;
int i = 1;
int result = seconddigit;
while (i < thirddigit)
{
    result = result * seconddigit;
    i++;
}
Console.WriteLine($"{result} - resultat");
