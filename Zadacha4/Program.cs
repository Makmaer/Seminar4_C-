int Stepen (int a, int b)
{ int i=1; int  p = 1;
 while(i<=b)
 {
   p=p*a; i++;
 }
return p;
}
Console.WriteLine("Input  number a: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input  number b: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a в степени b =" + Stepen(n1, n2) );
