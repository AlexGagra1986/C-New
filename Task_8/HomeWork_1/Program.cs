//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.



//Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
int N = RetMessange("Введите Количество строк: ");
int M = RetMessange("Введите Количество столбцов: ");
int[,] array = new int[N, M];

AddArray();

int RetMessange(String msg){
 Console.Write(msg);
int  x = Convert.ToInt32(Console.ReadLine());
return x;
}

void AddArray(){

  for (int i = 0; i < 5 ; i++)
{ 
    Random x = new Random();
    for (int j = 0; j < 5 ;j++)
    {
        array[i,j] = x.Next(1, 9);
    }
}   printArray();
Console.WriteLine("------------------------------------------");
    arraySort();
}

void printArray(){
for (int i = 0; i < 5 ; i++)
{
  for (int j = 0 ; j < 5 ; j++)
  {
    Console.Write(array[i,j]);
  }
  Console.WriteLine("");
}
}

void arraySort(){
    for (int i = 0; i < 5 ; i++)
{
     for (int j = 0 ; j < 5 ; j++)
   {
   for (int k = 0 ; k < 5 ; k++)
   {
   for (int m = 0 ; m < 5 ; m++)
   {
   if (array[i,j]>array[k,m]){
   int t = array[i,j];
   array[i,j] = array[k,m];
   array[k,m] = t;
   }
   }
   }
   }
}
printArray();
}

