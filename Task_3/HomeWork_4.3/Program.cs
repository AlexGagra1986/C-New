Console.Write("--> Введите числа массива ");
int x = Convert.ToInt32(Console.ReadLine());




int[] array = new int[x.ToString().Length];
for(int i = 0;i < array.Length;i++){
array[i] = x%10;
x/=10;  
}
Array.Reverse(array);

for(int j = 0;j < array.Length;j++){
    Console.Write($"[{array[j]}]");
}


