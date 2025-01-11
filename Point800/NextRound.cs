long n = long.Parse(Console.ReadLine());
long k = long.Parse(Console.ReadLine());
long[] a = new long[n];
long NextRound = 0;
for (int i = 0; i < n; i++)
{
    long ar_el = long.Parse(Console.ReadLine());
    a[i] = ar_el;
}
for (int i = 0; i < n; i++)
{
    if (a[i] >= a[k - 1] && a[i] != 0)
    {
        NextRound++;
    }
}
Console.WriteLine(NextRound);