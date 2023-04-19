int N = RetMessange("Введите N "); 
int M = RetMessange("Введите M "); 
AddArray(M, N);

int RetMessange(String msg){
 Console.Write(msg);
int  x = Convert.ToInt32(Console.ReadLine());
return x;
}

void AddArray(int M,int N){
double [,] array = new double[M, N];
for (int i = 0; i < M ; i++)
{ 
    Random x = new Random();
    for (int j = 0; j < N ;j++)
    {
        array[i,j] = x.Next(-15, 15);
        Console.Write("{0}\t",array[i, j]);
    }
      Console.WriteLine("");
    }
}















