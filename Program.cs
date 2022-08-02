void Z() 
{



}
Z();

void Z1() 
{
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (num>0) 
{
num = num/10;
count++;
}
Console.WriteLine(count);


}
Z1();

void Z2() 
{
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()), 
inum = 0;
int anum = 1, res = 2;
while (anum<num) 
{
res = anum * res;
//Console.WriteLine(anum + " * " + res + " = " + res);
anum++;
inum++;
}
Console.WriteLine(res);
}
Z2();

void Z3() 
{

int [] array = new int [8];
int i = 0;
while (i<array.Length) 
Console.Write("[ ");
{
int num = new Random().Next(0, 2);
array [i] = num;
Console.Write(num + " ,");
i++;
}
Console.Write(" ]");


}
Z3();
