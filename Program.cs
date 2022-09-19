string[] arr1 = new string[4] {"SPb", "!", "=)", ")))))))"};
string[] arr2 = new string[arr1.Length];

void Arrs(string[] arr1, string[] arr2)

{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}

void Arrays(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


Arrs(arr1, arr2);
Arrays(arr2);