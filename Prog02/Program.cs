Console.Clear();
int x,y,max;
Console.WriteLine("Укажите целое x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите целое y");
y = Convert.ToInt32(Console.ReadLine());
if (x>y)
{
   max=x;
}
else
{
   max=y;
}
Console.WriteLine("Max="+max);
