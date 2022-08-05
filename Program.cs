void DZ1() 
{
Console.WriteLine("Введите два числа:");
int A = Convert.ToInt32(Console.ReadLine()), 
    B = Convert.ToInt32(Console.ReadLine());
double Ab = Math.Pow(A, B);
Console.WriteLine(A + " в степени " + B + " = " + Ab);
}
Console.WriteLine();
DZ1();

// Console.WriteLine("");
// void DZ2() 
// {
// //Console.WriteLine("Введите число: ");
// //int num = Convert.ToInt32(Console.ReadLine());
// int num = new Random().Next(0, 10000);
// num = Math.Abs(num);
// int dig, sum = 0, dug = num, dog = num, deg = 0;
// Console.Write("Сумма цифер числа ");
// while (dog > 0) 
// {
// dig = dog % 10;
// dug = (dog / 10) % 10;
// if (num > 999) 
// { 
//     deg = (dog / 100) % 10; 
//     dog /= 1000;
// }
// else dog = dog / 100;
// Console.WriteLine(num + " = " + $"{sum = dig + dug + dog + deg}");
// dog = (dog / 100);
// }
// }
// Console.WriteLine("");
// DZ2();


Console.WriteLine();
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
Console.WriteLine();
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
Console.WriteLine();
DZ3();


Console.WriteLine();
Console.WriteLine();
void DZ02() 
{
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()),
    nom = num,
    co = 0;
while (nom>0) 
{
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
Console.WriteLine();
DZ02();

Console.WriteLine();
void SMN2_DOZ1() 
{
    // Задача 1. Написать программу, которая определяет, 
    // является ли треугольник со сторонами a, b, c равнобедренным.

    Console.WriteLine("1. Введите значения сторон треугольника: ");
    int a = Convert.ToInt32(Console.ReadLine()), 
        b = Convert.ToInt32(Console.ReadLine()), 
        c = Convert.ToInt32(Console.ReadLine());
if (a == b || c == b || a == c) 
{
Console.WriteLine("Данный треугольник abc - равнобедренный");
}
else
Console.WriteLine("Данный треугольник abc - неравнобедренный");
}
Console.WriteLine();
SMN2_DOZ1();

Console.WriteLine();
void SMN2_DOZ2() 
{
    // Задача 2. На вход подаются год, номер месяца и день рождения человека, 
    // Определить возраст человека на момент 1 июля 2022 года.
    
int day = 1, month = 7, year = 2022;
    Console.WriteLine("2. Введите день, месяц и год вашего рождения: ");
    int myday = Convert.ToInt32(Console.ReadLine()), 
        mymonth = Convert.ToInt32(Console.ReadLine()),
        myyear = Convert.ToInt32(Console.ReadLine());
    if (myday <= 31 && myday > 0 && mymonth <= 12 && mymonth > 0 && myyear <= year && mymonth > month) 
    {
    myday = myday-day;
    mymonth = mymonth-month;
    myyear = year-myyear-1;
    Console.WriteLine("Вам " + myday + " дней, " 
    + mymonth + " месяцев, " + myyear + " лет.");
    } 
    else if (mymonth <= month) 
    {
        mymonth = month-mymonth;
        myyear = year-myyear;
        Console.WriteLine("Вам " + myday + " дней, " 
        + mymonth + " месяцев, " + myyear + " лет."); 
    } 
    else 
    {
        Console.WriteLine("Введена некорректная дата"); 
    }
}
Console.WriteLine();
SMN2_DOZ2();

Console.WriteLine();
void SMN2_DOZ3() 
{
    // Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
    // Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
    // Определить размер депозита через n месяцев.

double money = 1000, grow = 1.5, month=0;
    Console.WriteLine("3. Введите кол-во месяцев: ");
    double mymonth = Convert.ToInt32(Console.ReadLine());
    while (month<=mymonth) 
    {
        if (month % 2 == 0) 
        {
            double moneygrow = money * grow / 100; //Чтобы получать полный ответ
            money += moneygrow;
        }
        month++;
    }
    Console.WriteLine("Размер депозита через " + mymonth + " месяцев будет равен " + money);
}
Console.WriteLine();
SMN2_DOZ3();

Console.WriteLine();
void SMN2_DOZ4() 
{
    // Дано натуральное число, в котором все цифры различны. 
    // Определить, какая цифра расположена в нем левее: максимальная или минимальная.

  Console.WriteLine("4. Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine()),
        min = num % 10,
        max = 0,
        dig = num,
        dug = num,
        numco=0,
        namco=0;
        while (dug > 0)
        {
            dig = dug % 10;
            dug /=10;
            if (dig>max) 
            { 
                max = dig; 
                numco++; 
            }
            else if (dig<=min) 
            {
                min = dig; 
                namco++;
            }
        } 
        Console.WriteLine("В числе " + num + " цифра " + max + " - максимальное, " + min + " - минимальное");
        if (numco<=namco) Console.WriteLine("Минимальное число находится левее");
        else Console.WriteLine("Максимальное число находится левее");
}
Console.WriteLine();
SMN2_DOZ4();