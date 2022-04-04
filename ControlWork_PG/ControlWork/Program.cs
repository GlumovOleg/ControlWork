// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] arr1 = new string[9] { "hello", "2", "word", ":-)", "123", "23", "-2", "Russian", "res" };
string[] arr2 = new string[arr1.Length];

void SecondArrayIsFilling(string[] arr1, string[] arr2)
{
    int element = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[element] = arr1[i];
            element++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayIsFilling(arr1, arr2);
PrintArray(arr2);