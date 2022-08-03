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
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = new Random().Next(1, 2000000001);
num = Math.Abs(num);
int dig, sum = 0, dug = num, dog = num, ten = 10;
while (dug > 0) 
{
//dog /= ten;
dig = dug % 10;
dug = (dug / 10) / 10;
//dog /= ten;
//ten *= 10; 
Console.WriteLine(num + "-->" + $"{sum = dig + dug}");
}
//Console.WriteLine(num + " --> " + sum);
}
Console.WriteLine("");
DZ2();


Console.WriteLine("");
void DZ3() 
{



}
DZ3();
