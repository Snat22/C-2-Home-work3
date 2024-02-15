int MinNumber(int a,int b) 
{   
    
    int maxi = -99999;
    if (a>b)
    {
        maxi = a;
    }else if(b>a)
    {
        maxi = b;
    }else
    {
        System.Console.WriteLine("Number is Equal");
        return 0;
    }
    return maxi;
}

System.Console.WriteLine("Write Your Number for find MaxNum:");
System.Console.Write("First Number: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Second Number: ");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("*****************");
System.Console.Write("Max Number Is : ");
System.Console.Write(MinNumber(a,b));