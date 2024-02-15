System.Console.Write("Write 2 number for Canculated \nFirst Number :");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Second Number :");
int b = int.Parse(Console.ReadLine());

int AddNum(int a,int b)
{
    return a + b;
}

System.Console.WriteLine("<============================>");
System.Console.WriteLine($"Add: {AddNum(a,b)}");


int Subtract(int a,int b)
{
    return a - b;
}

System.Console.WriteLine("<============================>");
System.Console.WriteLine($"Division: {Subtract(a,b)}");

int Multiply(int a,int b)
{
    return a * b;
}

System.Console.WriteLine("<============================>");
System.Console.WriteLine($"Multiply: {Multiply(a,b)}");

int Division(int a,int b)
{
    return a / b;
}
System.Console.WriteLine("<============================>");
System.Console.WriteLine($"Division: {Division(a,b)}");
System.Console.WriteLine("<============================>");
