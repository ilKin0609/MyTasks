int[,] a = new int[5, 5];
int x = 0;
int y = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        int ar_el = int.Parse(Console.ReadLine());
        a[i, j] = ar_el;
        if (a[i, j] > 0)
        {
            x = i + 1;
            y = j + 1;
        }
    }
}
int cnt = (Math.Abs(x - 3)) + Math.Abs(y - 3);
Console.WriteLine(cnt);