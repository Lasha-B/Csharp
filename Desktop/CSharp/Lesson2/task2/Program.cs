﻿int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n) // While (i < arr.Length) возможно воспользоваться как переменной 
// массива "N", так и свойством массива "arr.Length". 
{
    arr [i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(' ');
    Console.Write ($"{arr[i]} ");
    i = i + 1;
}