
int n= Convert.ToInt32(Console.ReadLine());

int[] ints = new int[n];
for (int i=0; i<n; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
}
int min = Convert.ToInt32(99999);
int z = Convert.ToInt32(0);

for (int i=0; i<n; i++)
{
    if (ints[i]<min)
    {
     min=ints[i];
     z=i;
    }
}
System.Console.WriteLine(z);
