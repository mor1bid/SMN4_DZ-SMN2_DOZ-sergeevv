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
int anum = 1, bnum = 2;
while (inum<num) 
{
int res = anum * bnum;
Console.WriteLine(anum + " * " + bnum + " = " + res);
anum++;
bnum++;
inum++;
}
}
Console.WriteLine("");
Z2();


Console.WriteLine("");
void Z3() 
{

int [] array = new int [8];
int i = 0;
Console.Write("[ ");
while (i<array.Length) 
{
int num = new Random().Next(0, 2);
array [i] = num;
Console.Write(num + ", ");
i++;
}
Console.Write("\b\b ");
Console.Write(" ]");


}
Z3();
