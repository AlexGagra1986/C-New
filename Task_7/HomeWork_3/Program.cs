﻿//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Sum();
void Sum (){

    int [,] array = new int[3,4] {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
    int [] sum = new int [4];
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 3; j++)
        {   
           sum[i]+=array[j,i];
        }
        
    } for (int k = 0; k < 4 ; k++)
            {
                float res = sum[k]/3f;
                Console.Write(res+" ");
            }
            
            Console.ReadLine();
}

