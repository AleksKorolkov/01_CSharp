int n = 10;
int[] arr = new int [n];
int i = 0;

while (i < arr.Lenght) // Lenght - хранит количество элементов, под которое выделена память
{
    arr [i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(" ");
    Console.Write($"{arr[i]} ");   // тоже, что и 2 строки выше, но одной строкой
    i = i + 1;
}