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
int dig, sum = 0, dug = num, dog = num, deg = 0;
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
Console.WriteLine(num + "-->" + $"{sum += dig + dug + dog + deg}");
dog = (dog / 100);
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
