
int n= Convert.ToInt32(Console.ReadLine());

int[] ints = new int[n];

for (int i=0; i<n; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
}
 for (int i=n-1; i>0; i--)
    {
        if (ints[i-1] > 0 && ints[i] > 0 || ints[i-1] < 0 && ints[i] < 0)
        {
           System.Console.Write(ints[i] +" "+ ints[i-1]);
           break;
        }
       
    }
        