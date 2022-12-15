
int []arr = Auto();
System.Console.WriteLine(string.Join(", ", arr));

int[] Auto()
{
    int[] arr = new int[8];
    Random rand = new Random();

    for (int i = 0; i < 8; i++)
    {
        arr[i] = rand.Next(0, 101);
    }
    return arr;
}
