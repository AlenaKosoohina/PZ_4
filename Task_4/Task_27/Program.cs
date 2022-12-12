int a = int.Parse(Console.ReadLine());
Console.WriteLine(Summa(a));

int Summa(int chislo)
{
    int result = 0;
        while (chislo>=9)
    {
        result=result+chislo%10;
        chislo=chislo/10;
    }
    result=result + chislo;

    return result;
}