//Алгоритм сортировки выбором
void Main()
{
    Console.WriteLine("Start Selection Sort");
    int[] array = { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 }; //Инициализация неотсортированного массива.
   ;
    SelectionSort();
}
int SelectionSort(int array)
{
    int temp = 0;
    int smallest = 0;
    
    for (int i = 0; i < array.Length-1; i++) {
         smallest = i;
         for (int j = i + 1; j < n; j++) {
            if (arr[j] < arr[smallest]) {
               smallest = j;
            }
         }
         temp = arr[smallest];
         arr[smallest] = arr[i];
         arr[i] = temp;
      }
}
Main();