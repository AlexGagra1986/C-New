
fs();
int fs(){
    Console.WriteLine("Введите количество цифр");
    int m = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int count = 0;
    while (m>i)
    {  
        i++;
        Console.Write("Введите Число ");
        int x = Convert.ToInt32(Console.ReadLine());
       
        if(x>0){
            count++;
          }
    }
Console.WriteLine($"Количество положительных чисел {count}");
    return 0;
}

