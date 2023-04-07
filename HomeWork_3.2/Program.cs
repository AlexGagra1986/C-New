  Console.Write("Введите переменные Первой точки");
       int xa = Convert.ToInt32(Console.ReadLine());
       int ya = Convert.ToInt32(Console.ReadLine());
       int za = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите переменные Второй точки");  
       int xb = Convert.ToInt32(Console.ReadLine());
       int yb = Convert.ToInt32(Console.ReadLine()); 
       int zb = Convert.ToInt32(Console.ReadLine());  
     
  
 double Result = GetK(xa,ya,za,xb,yb,zb);
 String s = Result.ToString("F3");

 Console.Write($"-->Результат равен {s}");  
 
  double GetK (int xa,int ya,int za,int xb,int yb,int zb){

      int step1 = (int)Math.Pow(xa-xb, 2) + (int)Math.Pow(ya-yb, 2) + (int)Math.Pow(za-zb, 2);
      
      double step2 = Math.Sqrt(step1);
return step2;
  }

 