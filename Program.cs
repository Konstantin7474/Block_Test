string[] GiveArray = new string[4] { "hello", "2", "world", ":-)"};
string[] ResultArray  = new string[GiveArray.Length];


FillArray(GiveArray, ResultArray);
PrintArray(ResultArray);


void FillArray(string[] GiveArray, string[] ResultArray)
{
    int count = 0;
    for (int i = 0; i < GiveArray.Length; i++)
    {
        if(GiveArray[i].Length <= 3)
        {
            ResultArray[count] = GiveArray[i];
            count++;
        }
    }
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}
