// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] NewArrayOfStringsWhoseLengthIsLessThanOrEqualNumberOfCharacters(string[] array, int numberOfCharacters)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) { if (array[i].Length > 0 && array[i].Length <= numberOfCharacters) { count++; } }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++) { if (array[i].Length > 0 && array[i].Length <= numberOfCharacters) { newArray[j] = array[i]; j++; } }
    return newArray;
}

Console.WriteLine("Введите элементы массива, разделяя их запятой и пробелом (', '): ");
string[] input = Console.ReadLine().Split(", ").ToArray();

string[] output = NewArrayOfStringsWhoseLengthIsLessThanOrEqualNumberOfCharacters(input, 3);

Console.WriteLine();
Console.WriteLine("Ответ: ");
Console.WriteLine("[" + string.Join((", "), output) + "]");
