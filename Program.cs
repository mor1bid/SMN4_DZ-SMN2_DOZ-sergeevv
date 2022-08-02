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