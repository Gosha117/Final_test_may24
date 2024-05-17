// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Создание массива
string[] enter_str = { "ruw", "oeru", "qo", "rur4o", "2", "tu", "t", "ry", "386g", "etyerye", "57", "dh", "g", "h", "re", "24", "7f", "785", "6cvb", "ete", "sge", "r", "ed", "w" };

// введение максимального количества символов для возвращаемого элемента массива 
int num_sim = 3;

// Создание возвращаемого массива
string[] new_str = new string[enter_str.Length];

// Вывод массива строк
void Print_array(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// Выбор искомых элементов массива и формирование нового массива
string[] Find_simbol(string[] array, int n_simbol)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string temp_str = array[i];
        if (temp_str.Length <= n_simbol)
        {
            new_str[j] = array[i];
            j++;
        }
    }
    return new_str;
}


Console.Write("Исходный массив: ");
Print_array(enter_str);

Console.WriteLine();

Console.Write("Новый массив: ");
Print_array(Find_simbol(enter_str, num_sim));




