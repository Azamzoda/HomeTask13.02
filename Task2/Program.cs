
int n= Convert.ToInt32(Console.ReadLine());

int[] ints = new int[n];
for (int i=0; i<n; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
}
 int sum = Convert.ToInt32(1); 
for (int i=0; i<n; i++)
{
    sum=sum*ints[i];
    if (i>0)
    {
        System.Console.Write("*");
        if(i==n)
        {
            break;
        }
    }
        System.Console.Write(ints[i]);
    
}
    System.Console.Write("="+sum);
