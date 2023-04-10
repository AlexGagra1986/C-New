Console.Write("--> Введите число A : ");
       int a = Convert.ToInt32(Console.ReadLine());
Console.Write("--> Введите число B : ");   
 int b = Convert.ToInt32(Console.ReadLine());  
expo(a,b);

int expo(int a, int b){

int num = 1;

for (int i = 0; i < b; i++) {
        num *= a;
Console.Write($"--> {num} ");
    }
    return num;
}

