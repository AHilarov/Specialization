int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(System.Console.ReadLine());
    return temp;
}

string PromptText(string strMessage)
{
    System.Console.Write(strMessage);
    string? temp = Console.ReadLine();
    return temp;
}

void FillArray(string[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        string word = PromptText($"Введите {i + 1} слово: ");
        collection[i] = word;
    }
}

string[] RefillArray(string[] collection, int a)
{
    string[] NewTextArray = new string[a];
    int j = 0;
    string temp = String.Empty;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length < 4 && collection[i].Length > 0)
        {
            temp = collection[i];
            NewTextArray[j] = temp;
            j++;
        }
    }
    return NewTextArray;
}

int CountElements(string[] collection)
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i].Length < 4 && collection[i].Length > 0)
            count++;
    }
    return count;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write($"“{array[array.Length - 1]}”]");
    Console.WriteLine();
}

void Execute()
{
    Console.WriteLine(
        "Данная программа принимает на вход указанное пользователем количество слов,"
            + " а затем выдает все слова менее 4 символов."
    );
    int digit = Prompt("Сколько слов вы планируете ввести? ");
    if (digit < 1)
    {
        Console.WriteLine("Надо ввести хотя бы одно слово. Попробуйте ещё раз.");
        Console.WriteLine();
        Execute();
    }
    string[] TextArray = new string[digit];
    FillArray(TextArray);
    int a = CountElements(TextArray);
    Console.WriteLine();

    if (a != 0)
    {
        string[] NewTextArray = RefillArray(TextArray, a);
        PrintArray(NewTextArray);
    }
    else
    {
        Console.WriteLine("[]");
    }
}

Execute();
