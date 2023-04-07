       Console.Write("--> Введите число : ");
       int num = Convert.ToInt32(Console.ReadLine());
       Console.Write($"Число {num} = {IsPalindrome(num)}  ");
  
          


 static bool IsPalindrome(int num)
        {
            if (num >= 0 && num <10) /// Если число двухзначное возвращаем истину
                return true;
            int numLength = GetLength(num); /// получаем длинну числа
            int[] digits = new int[numLength]; ///  ложим в массив число
            for (int i = numLength - 1; i >= 0; i--) {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength/2; i++) {
                if (digits[i] != digits[numLength - i - 1])
                    return false;
            }
            return true;
        }
        
        static int GetLength(int num)
        {
            int n = 0;
            while (num > 0) {
                num /= 10;
                n++;
            }
            return n;
        }
    

