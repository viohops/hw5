// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


// int[] GenerteArr(int size, int min, int max){
//     Random rand = new Random();
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rand.Next(min, max+1);
//     }
//     return arr;
// }

//  int evenNumbers(int[] arr){
//     int even = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] % 2 == 0) {
//             even++;
//         }
//     }
//     return even;
//  }

// int[] array = GenerteArr(10, 100, 999);
// int even = evenNumbers(array);
// System.Console.WriteLine("[{0}]", string.Join(", ", array));
// System.Console.WriteLine(even);




// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0


// int[] GenerteArr(int size, int min, int max){
//     Random rand = new Random();
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rand.Next(min, max+1);
//     }
//     return arr;
// }

//  int NotEvenIndex(int[] arr){
//     int index = 0;
    
//     for (int i = 1; i < arr.Length; i++)
//     {
//        if(i%2!=0)  index += arr[i];
//     }
//     return index;
//  }

// int[] array = GenerteArr(5, 1, 10);
// int sumIndex = NotEvenIndex(array);
// System.Console.WriteLine("[{0}]", string.Join(", ", array));
// System.Console.WriteLine(sumIndex);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GenerteArr(int size, int min, int max){
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max+1);
    }
    return arr;
}

 void MinMax(int[] arr, out int min, out int max){
    min = arr[0];
    max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<min) min = arr[i];
        if(arr[i]>max) max = arr[i];
        
    }
    
    
 }

int[] array = GenerteArr(5, 1, 10);
MinMax(array, out int min, out int max);

System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine($"Разница между мксимальным и минимальным числом массива {max-min}");
