int MinNumber(int a,int b) 
{
    int min = 99999;
    if (a<b)
    {
        min = a;
    }else if(b<a)
    {
        min = b;
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
System.Console.WriteLine("*****************");
System.Console.Write("Min Number Is : ");
System.Console.Write(MinNumber(a,b));