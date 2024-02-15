void Swap(ref int x,ref int y)
{
    int c = 0;
    c = x;
    x = y;
    y = c;
    System.Console.WriteLine($"{x} {y}");
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


Swap(ref a, ref b);
System.Console.WriteLine($"{a} {b}");

