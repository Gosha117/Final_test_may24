﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] str = { "ruw", "oeru", "qo", "rur4o", "2", "tu", "t", "ry", "386g", "etyerye", "57", "dh", "g", "h", "re", "24", "7f", "785", "6cvb", "ete", "sge", "r", "ed", "w" };
// Создание массива
// void Create_array()
// {
//     string[] str = { "ruw", "oeru", "qo", "rur4o", "2", "tu", "t", "ry", "386g", "etyerye", "57", "dh", "g", "h", "re", "24", "7f", "785", "6cvb", "ete", "sge", "r", "ed", "w" };
// }

// Вывод массива
void Print_array()
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write(str[i] + " ");
    }
}

//Create_array();
Print_array();



// Console.WriteLine("Hello, World!");


