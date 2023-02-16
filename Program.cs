string[] arr = new string[5]{"55","Moscow","yes","Dushanbe","GB"};
Console.Write(string.Join("; ", arr));
Console.WriteLine();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3) count++;
}