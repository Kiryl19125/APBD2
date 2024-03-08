// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine(GetAvg([1, 2, 3, 4, 5]));

return;

// modification 1
// modification 2
// modification 3

static float GetAvg(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return (float)sum / arr.Length;
}