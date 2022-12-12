int[] array =new int[8];
Random rnd = new Random(50);
for (int i = 0; i < 8; i++)
{
    array[i] = rnd.Next(0,50);
    Console.Write($"{array[i]} ");
}
