﻿int KolCifr (int n)
{ int s=0;
 while(n>0)
 {
    n=n/10;
    s=s+1;
 }
return s;
}

int SumCif (int kolich, int n)
{ int sum = 0; int ost = n; 
    for (int i = kolich; i >= 1; i--)
    {
        int b = i-1, a = 10, p=1, j=1;
         while(j<=b)
         {
        p=p*a; j++;
         }
       sum = sum + (ost / p);
       ost = ost % p;
    }
    return sum;
}
Console.WriteLine("Input positiv integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int kol=KolCifr(num);
Console.WriteLine("Количество цифр в числе =  " + kol );
Console.WriteLine("Сумма цифр в числе =  " + SumCif(kol, num) );
