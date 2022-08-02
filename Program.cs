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
while (inum<num) 
{
int anum = 1, bnum = 2;
string res = ($"{anum * bnum}");
Console.WriteLine(anum + " + " + bnum + " = " + res);
anum++;
bnum++;
}

}
Z2();