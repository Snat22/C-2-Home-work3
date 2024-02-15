int MinNumber(int a, int b, int c, int d) 
{
    int min = 99999;
    if (a<b && a<c & a<d)
    {
        min = a;
    }else if(b<a && b < c && b < d)
    {
        min = b;
    }else if(c<a && c < b&& c < d)
    {
        min = c;
    }else if(d < a && d<b && d<c)
    {
        min = d;
    }else
    {
        System.Console.WriteLine("Number is Equal");
        return 0;
    }
    return min;
}

System.Console.WriteLine("Write Your Number for find MinNum:");
System.Console.Write("First Number: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Second Number: ");
int b = int.Parse(Console.ReadLine());
System.Console.Write("Third Number: ");
int c = int.Parse(Console.ReadLine());
System.Console.Write("Fourth Number: ");
int d = int.Parse(Console.ReadLine());
System.Console.WriteLine("*****************");
System.Console.Write("Min Number Is : ");
System.Console.Write(MinNumber(a,b,c,d));