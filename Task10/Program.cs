
int n= Convert.ToInt32(Console.ReadLine());

int[] ints = new int[n];

for (int i=0; i<n; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i=0; i<n; i++)
{
    if(ints[i]%2!=0)
    System.Console.Write(ints[i]*ints[i] + " ");
}