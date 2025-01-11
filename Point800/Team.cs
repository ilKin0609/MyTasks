int n = int.Parse(Console.ReadLine());
int[] a = new int[3];
int cnt = 0;
int len = n;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < 3; j++)
    {
        int a_el = int.Parse(Console.ReadLine());
        a[i] = a_el;
        if (a[i] == 1)
        {
            cnt++;
        }
    }
    if (cnt < 2)
    {
        len--;
    }
    cnt = 0;
}
Console.WriteLine(len);