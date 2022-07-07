int FindSum(int A)
{
      int current = 1, sum = 0;
    while (current <= A)
    {
        sum+= current;
        current++;
    }
    
    return sum;
}
 Console.WriteLine("Input positiv integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum is " + FindSum(num) );