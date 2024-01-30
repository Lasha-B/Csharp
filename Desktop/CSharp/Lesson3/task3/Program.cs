void ZeroEventElements(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = {15,16,3,55,54,35};
ZeroEventElements(array);
PrintArray(array);
