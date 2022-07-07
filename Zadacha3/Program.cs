int Proizvedenie (int n)
{ int p=1, i=1;
 while(i<=n)
 {
   p=p*i; i++;
 }
return p;
}
Console.WriteLine("Input positiv integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Proizvedenie " + Proizvedenie(num) );