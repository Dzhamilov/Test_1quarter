string[] arr = new string[5]{"55","Moscow","yes","Dushanbe","GB"};
Console.Write(string.Join("; ", arr));
Console.WriteLine();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3) count++;
}

string[] NewArray(int size, string[] oldArray)
{
    string[] result = new string[size];
    int j = 0; 
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3) 
        {
            result[j] = oldArray[i];
            j++;
        }
    }
    return result;
}