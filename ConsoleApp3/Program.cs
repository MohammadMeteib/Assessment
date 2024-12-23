// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter number:");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num<= 1000)
{
    Console.WriteLine((num * (num + 1)) / 2);
}

Console.WriteLine("------------------");
string str = Console.ReadLine();
string vowels = "aeiou";
int i = 0;
int sum = 0;
foreach (char c in str.ToLower())
{
    if (vowels.Contains(c))
    { sum+=1; }
    }
Console.WriteLine(sum);

Console.WriteLine("---------------");
int num1= Convert.ToInt32(Console.ReadLine());
if (num1 %2==0)
{
    Console.WriteLine("true");
}else {  Console.WriteLine("false"); }

Console.WriteLine("-----------------------");
int factorial;
int num2 = Console.ReadLine();
for (int i = 0; i <= num2; i++)
{
    factorial *= num2
}

