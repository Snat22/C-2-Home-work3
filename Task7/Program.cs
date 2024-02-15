
void IncrementArrayElements(ref int[] arr, ref int b)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] += b;
    }

}
System.Console.Write("Write Size your Massive : ");
int c = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Write Number for Add : ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Write Element for Massive : ");
int[] arr = new int[c] ;
for (int i = 0; i < arr.Length; i++)
{
    arr[i]= Convert.ToInt32(Console.ReadLine()); 
}
IncrementArrayElements(ref arr, ref b);

foreach (var item in arr)
{
    System.Console.Write(item + " ");
}
