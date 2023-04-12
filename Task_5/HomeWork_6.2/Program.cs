///Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями

fn();

int fn (){
    Console.WriteLine("Введите b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    
   if(k1!=k2){
    double x = ((b2-b1)/(k1-k2));
    double y = k2*x+b2;
    Console.WriteLine($"{x}{" "}{y}");
   }else
   {
    Console.WriteLine("Линии паралельны");
   }
 return 0;
}
