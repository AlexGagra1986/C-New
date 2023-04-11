
int [] array = {-3,-6,89,6};

int chek = 0;
for (int i = 0;i < array.Length;i++){
    if(i%2>0){
        chek=array[i]+chek;
        }

}
Console.Write(chek);
