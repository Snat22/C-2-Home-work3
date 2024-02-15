// Дано положительное число n. Найдите :
// Количество четных чисел. => int EvenCount(int n)

// Количество нечетных чисел. => int OddCount(int n)

// Количество цифр. => int DigitCount(int n)

// Сумма цифр. => int SumDigit(int n)

int EvenCount(int n)
{
    int even = 0;

    for (int i = n; i > 0; i/=10)
{
    if (i%2==0) even++;
}
 return even;
}

int OddCount(int n)
{
    int odd = 0;

    for (int i = n; i > 0; i/=10)
{
    if (i%2!=0) odd++;
}
 return odd;
}

int DigitCount(int n)
{
    int cnt = 0;

    for (int i = n; i > 0; i/=10)
{
     cnt++;
}
 return cnt;
}
 int SumDigit (int n)
{
    int sum = 0;

    for (int i = n; i > 0; i/=10)
{
  sum += i % 10;
}
 return sum;
}


int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine($"Even: {EvenCount(n)}");
System.Console.WriteLine($"Odd: {OddCount(n)}");
System.Console.WriteLine($"Digit: {DigitCount(n)}");
System.Console.WriteLine($"Sum of Digit {SumDigit(n)}");