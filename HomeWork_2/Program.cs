 firstNumber();
secondNumber();
days();


//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

int firstNumber(){
  Console.Write("Первое задание---> Введите трехнзачное число : ");
  int number = Convert.ToInt32(Console.ReadLine());
 
 if (number >=100 && number <1000){

    int res = (number % 100 - number %10)/10;
    System.Console.WriteLine($"Вторая цифра числа {number} является {res}");
}
else 
System.Console.WriteLine($"Число {number} не является трехзначным числом");
return number;
}
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
int secondNumber(){

Console.Write("Второе задание---> Введите трехзначную цифру :");
int number = Convert.ToInt32(Console.ReadLine());
int res = number%10;
int num = 100;
  if (number >= num){
  System.Console.WriteLine($"Третьим числом является: {res}");
  }else
  System.Console.WriteLine($"Не являеться трехзначным числом");

return res;
}
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 int days(){
    Console.Write("Третье задание ---> Введите день :");
   int number = Convert.ToInt32(Console.ReadLine());
   if (number>=1&&number<=5){
       System.Console.WriteLine($"Нет");
   }else
   System.Console.WriteLine($"Да");
   return number;
 }
