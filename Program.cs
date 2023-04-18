Console.Clear();

string[] arr = ReadeConsole("Введите элементы массива через запятую: ").Split(',');
string[] newArr = FilterShortStrings(arr, 3);
PrintResult(newArr);

///////////////////////////////////////////////////////////////////////////////////
string[] FilterShortStrings(string[] arr, int length)
{
    string[] newArr = new string[arr.Length];
    int index = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Trim().Length <= length)
        {
            newArr[index] = arr[i];
            index++;
        }
    }
    return newArr;
}

void PrintResult(string[] strs)
{
    int count = 0;
    for(int i = 0; i < strs.Length; i++)
    {        
        if(!string.IsNullOrEmpty(strs[i]))
        {
            if(count > 0)
            {
                Console.Write(",");
            }

            Console.Write(strs[i]);
            count++;
        }
    }
}

string ReadeConsole(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}