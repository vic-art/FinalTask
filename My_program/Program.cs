Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine()!;
string[] tokens = input.Split(" ");

string[] result = ShortWordsArray(tokens, 3);
Console.WriteLine("Измененный массив:");
PrintArray(result);


string[] ShortWordsArray(string[] _array, int maxLength)
{
    string[] _result = new string[_array.Length];
    int count = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i].Length <= maxLength)
        {
            _result[count] = _array[i];
            count++;
        }
    }
    Array.Resize(ref _result, count);
    return _result;
}

void PrintArray(string[] _array)
{
    if (_array.Length == 0)
        Console.Write("Array is empty.");
    else
    {
        for (int i = 0; i < _array.Length; i++)
        {
            Console.Write($"{_array[i]} ");
        }
    }
}






















