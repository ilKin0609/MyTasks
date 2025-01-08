long n = long.Parse(Console.ReadLine());

while (n > 0)
{
    string s = Console.ReadLine();

    if (s.Length > 10)
    {
        Console.WriteLine($"{s[0]}{s.Length - 2}{s[s.Length - 1]}");
    }
    else
        Console.WriteLine(s);
    n--;
}