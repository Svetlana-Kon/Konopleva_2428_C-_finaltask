/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться к
оллекциями, лучше обойтись исключительно массивами. */


void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine();
}

string[] startArray = {"hello", "my", "friends", ":-)", "1234", "123", "!" };
int count = 0;
string[] finalArray = new string[startArray.Length];

for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        finalArray[count] = startArray[i];
        count++;
    }
}

