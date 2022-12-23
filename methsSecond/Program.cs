Console.WriteLine("Enter the number:");
int.TryParse(Console.ReadLine(), out int s);

GetAndSortArray(out int[] arr);
var sortedArray = arr;
var secArr = GetArrayFromConsole(s);
//sArr = SortArray(secArr);
ShowArray(secArr);

static int[] GetArrayFromConsole(int size = 5)
{
    var result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        Console.Write("Введите элемент массива номер {0}: ", i + 1);
        result[i] = int.Parse(Console.ReadLine());
    }

    return result;
}
static void GetAndSortArray(out int[] ints, int size = 5)
{
    ints = GetArrayFromConsole(5);
    Array.Sort(ints);
    for(int i = 0; i < ints.Length; i++)
    {
        Console.Write(ints[i] + " ");
    }
    Console.WriteLine();
}
static int[] SortArray(int[] arr)
{
    int t;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for(int j = 1; j < arr.Length; j++)
        {
            if(arr[j] < arr[j - 1])
            {
                t = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = t;
            }
        }
    }
    return arr;
}
static void ShowArray(int[] arr, bool IsSort = false)
{
    if(!IsSort)
    {
        arr = SortArray(arr);
    }
    foreach(int a in arr)
    {
        Console.Write(a + " ");
    }
}