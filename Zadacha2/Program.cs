int KolCifr (int n)
{ int s=0;
 while(n>0)
 {
    n=n/10;
    s=s+1;
 }
return s;
}
Console.WriteLine("Input positiv integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество цифр в числе = " + KolCifr(num) );