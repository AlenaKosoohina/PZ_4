int a =int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(DegreeOfNumber(a,b));

int DegreeOfNumber(int from, int to)
{
    int result = 1;
    int i = 1;
    while (i <= to)
    {
        result = result * from;
        i++;
    }
    return result;
}