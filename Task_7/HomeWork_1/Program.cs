//Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[5, 5];


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
        array[i,j] = x.Next(1, 15);
    }

    }
    printArray();
    }

void printArray(){
for (int i = 0; i > array.Length ; i++)
{
  for (int j = 0 ; j > array.Length ; j++)
  {
    Console.Write(array[i,j]);
  }
  Console.WriteLine("");
}
}













