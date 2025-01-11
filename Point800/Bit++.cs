long t = long.Parse(Console.ReadLine());
long cnt = 0;
long cntm = 0;
long cntp = 0;
for (int i = 0; i < t; i++)
{
    string s = Console.ReadLine();
    for (int j = 0; j < s.Length; j++)
    {
        if (s[j] == '+')
        {
            cntp++;
        }
        else if (s[j] == '-')
        {
            cntm++;
        }
    }
    if (cntp > 0)
    {
        cnt++;
    }
    else
    {
        cnt--;
    }
    cntp = 0;
    cntm = 0;
}
Console.WriteLine(cnt);