Console.WriteLine("vvedi naturalnoe trehzn chislo");
int num=Convert.ToInt32(Console.ReadLine());
int a=num/100;
int c=num%10;
int newnum=a*10+c;
Console.WriteLine($"{newnum} - novoe chislo");