void DZ1() 
{
Console.WriteLine("Введите два числа:");
int A = Convert.ToInt32(Console.ReadLine()), 
    B = Convert.ToInt32(Console.ReadLine());
double Ab = Math.Pow(A, B);
Console.WriteLine(A + " в степени " + B + " = " + Ab);
}
Console.WriteLine("");
DZ1();

Console.WriteLine("");
void DZ2() 
{
//Console.WriteLine("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
int num = new Random().Next(0, 10000);
num = Math.Abs(num);
int dig, sum = 0, dug = num, dog = num, deg = 0;
Console.Write("Сумма цифер числа ");
while (dog > 0) 
{
dig = dog % 10;
dug = (dog / 10) % 10;
if (num > 999) 
{ 
    deg = (dog / 100) % 10; 
    dog /= 1000;
}
else dog = dog / 100;
Console.WriteLine(num + " = " + $"{sum = dig + dug + dog + deg}");
dog = (dog / 100);
}
//Console.WriteLine(num + " --> " + sum);
}
Console.WriteLine("");
DZ2();


Console.WriteLine("");
void DZ3() 
{
int [] ray = new int [8];
int [] ar = new int [8];
int si = ray.Length, 
    i = 0;
Console.Write("Из: [");
while (i<si) 
{
    int num = new Random().Next(-50, 51);
    int dig = Math.Abs(num);
    ray[i] = num;
    ar[i] = dig;
    Console.Write(ray[i] + ", ");
    i++;
}
i = 0;
Console.Write("\b\b" + "]");
Console.WriteLine("");
Console.Write("В: [");
int j = i + 1, tmp = 0;
while (i<si) 
{
    int min = i;
    while (j < si) 
    {
        if (ar[j] < ar[min]) min = j;
        j++;
    }
    tmp = ray [i];
    ray [i] = ray [min];
    ray [min] = tmp;
    tmp = ar [i];
    ar [i] = ar [min];
    ar [min] = tmp;
    Console.Write(ray[i] + ", ");
    i++;
    j = i + 1;
}
Console.Write("\b\b" + "]");
}
Console.WriteLine("");
DZ3();


Console.WriteLine("");
void DZ02() 
{
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()),
    nom = num,
    co = 0;
while (nom>0) 
{
    //numa = numb % 10;
    nom /= 10;
    co++;
}
int [] ray = new int [co];
int numa = 0,
    numb = num, i = 0, sum = 0;
while (i<co) 
{
    numa = numb % 10;
    sum += numa;
    numb /= 10;
    ray [i] = numa;
    i++;
}
Console.WriteLine("Сумма цифер числа " + num + " = " + sum);
}
DZ02();