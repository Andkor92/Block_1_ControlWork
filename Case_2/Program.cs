// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите элементы массива, разделяя их между собой нажанием клавиши 'Enter': ");

string input;
string[] inputArr;
int count = 0;
string[] outputArr = new string[count];
do
{
    input = Console.ReadLine();
    if (input != "" && input.Length <= 3)
    {
        count++;
        inputArr = new string[count];
        for (int i = 0; i < inputArr.Length - 1; i++)
            inputArr[i] = outputArr[i];
        inputArr[count - 1] = input;
        outputArr = inputArr;
    }
} while (input != "");

Console.WriteLine("Ответ: ");
Console.WriteLine("[" + string.Join((", "), outputArr) + "]");
