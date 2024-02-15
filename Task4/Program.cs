int Pow(int x,int y)
{
    int a = 1;
    for (int i = 0; i < y; i++)
    {
        a *= x;
    }
    return a;
}
System.Console.Write("Write 2 number for Canculated \nFirst Number :");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Second Number :");

int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Pow: {Pow(a,b)}");