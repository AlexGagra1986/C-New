// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

 Console.Write("Введите Число N: ");
 int num = Convert.ToInt32(Console.ReadLine());
 int x = GetNumber(num);



int GetNumber(int num){
int i = 1;
while (i <= num) {  
  int Result = (int)Math.Pow(i, 3);
   Console.Write($"{Result}{" "}");
  i++;
}
return 0;
}