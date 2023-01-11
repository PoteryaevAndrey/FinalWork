// // Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// // длина которых меньше либо равна 3 символам. Первоночальный массив можно ввести с клавиатуры, 
// // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// // колекциями, лучше обойтись исключительно массивами.


using static System.Console;
Clear();

string[] array1 = new string[6] {"window", "dog", "hey", "world", "cat", "peace"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);