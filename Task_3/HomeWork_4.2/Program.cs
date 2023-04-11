///Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
///452 -> 11
Console.Write("--> Введите число N : ");
       int x = Convert.ToInt32(Console.ReadLine());

int a = 0;
int sum = 0;
while (x>0){
 a  = x % 10;
 sum = sum+a;
 x/=10;
}
  Console.Write(sum); 

    




