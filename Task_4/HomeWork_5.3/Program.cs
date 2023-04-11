
double[] array = {2,3,78,7,22};
double min = array[0];
double max = 0;
for(int i = 0;i < array.Length;i++){
if(array[i]>max){ max = array[i];}
if(array[i]<min){ min = array[i];}
}
double result = max-min;
Console.Write(result);