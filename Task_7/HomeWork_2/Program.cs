// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же 
//указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
int x = RetMessange("Введите число "); 

AddArray(x);

int RetMessange(String msg){
 Console.Write(msg);
int  x = Convert.ToInt32(Console.ReadLine());
return x;
}

 void AddArray(int target){
int [,] array = new int[3,4] {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
int p = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4;j++)
    {
        if(target==array[i,j]){
            p = i;
            break;
        }
}
}
if(p >0 ) {
            Console.WriteLine($"Элемент {target} есть в массиве");
        }else
        {
            Console.Write($"Элемента нет в массиве");
        }
}

