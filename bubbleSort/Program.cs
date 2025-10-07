// See https://aka.ms/new-console-template for more information
using bubbleSort;

Console.WriteLine("========================= BUBBLE SORT =========================");

//define and display array
int[] array = { 8, 2, 4, 7, 1, 3, 9, 6, 5 };
Console.Write("Array before sort:           ");
Sort.Display(array);
Console.WriteLine("");

//sort array ascending (smallest to largest)
Sort.Bubble_Sort_Ascending(array);
Console.Write("Array sorted ascending:      ");
Sort.Display(array);
Console.WriteLine("");

//reset array and define as array2
int[] array2 = { 8, 2, 4, 7, 1, 3, 9, 6, 5 };

//sort array descending (largest to smallest)
Sort.Bubble_Sort_Descending(array2);
Console.Write("Array sorted descending:     ");
Sort.Display(array2);

Console.WriteLine("\n===============================================================");
