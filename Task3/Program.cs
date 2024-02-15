
int n= Convert.ToInt32(Console.ReadLine());

int[] ints = new int[n];
for (int i=0; i<n; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
}
int big = Convert.ToInt32(-999999);

for (int i=0; i<n; i++)
{
    if (ints[i] > big)
    {
        big=i;
    }
}
System.Console.WriteLine(big);