
int [] array = {345,897,568,234};
int count = 0;
int chek = 0;
for (int i = 0;i < array.Length;i++){
    if(array[i]%2==0){
        chek++;
        }

}
Console.Write(chek);