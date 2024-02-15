int MaxDig(int n ){
int mx = -99999999;
for (int i = n; i > 0; i/=10)
{
    if (i % 10 > mx) mx = i % 10;
}
return mx;
}

int MInDig(int n ){
int min = 9999999;
for (int i = n; i > 0; i/=10)
{
    if (i % 10 < min) min = i % 10;
}
return min;
}
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write(MaxDig(n));
System.Console.Write(" + ");
System.Console.Write(MInDig(n));
int result =  MInDig(n) + MaxDig(n);
System.Console.Write(" = ");
System.Console.WriteLine(result);