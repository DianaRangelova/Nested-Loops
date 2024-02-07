int n = int.Parse(Console.ReadLine());
int lineEnd = 1;
int i = 1;

while (i <= n)
{
    for (int col = 1; col <= lineEnd; col++)
    {
        Console.Write(i + " ");
        i++;
        if (i > n)
        {
            break;
        }
    }
    Console.WriteLine();
    lineEnd++;
}

   