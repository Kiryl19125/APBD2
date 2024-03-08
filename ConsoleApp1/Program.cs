// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine(GetAvg([1, 2, 3, 4, 5]));
Console.WriteLine(GetMax([1, 2, 3, 4, 4, 666, 33, 5, 1]));

return;

// modification 1
// modification 2
// modification 3

static float GetAvg(int[] arr)
{
    int sum = 0;

    for (int k = 0; k < arr.Length; k++)
    {
        sum += arr[k];
    }

    return (float)sum / arr.Length;
}

static int GetMax(int[] arr)
{
    int max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
    }

    return max;
}