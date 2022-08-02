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
int num = new Random().Next(1, 2000000001);
int dig = num % 10, sum = dig + num;
while (num>1) 
{
num /= 10 % 10;
sum = dig + num;
}
Console.WriteLine(num + " --> " + sum);
}
Console.WriteLine("");
DZ2();


Console.WriteLine("");
void DZ3() 
{



}
DZ3();
