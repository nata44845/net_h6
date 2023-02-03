// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int PositiveCount(int[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

int size = GetNum("Введите количество элементов: ");

int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = GetNum($"Введите {i + 1} элемент: ");
}

Console.WriteLine("[" + String.Join(", ", array) + "] -> " + Convert.ToString(PositiveCount(array)));