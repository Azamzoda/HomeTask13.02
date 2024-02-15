
int n= Convert.ToInt32(Console.ReadLine());

int[] ints = new int[n];
for (int i=0; i<n; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt = Convert.ToInt32(0);

for ( int i=0; i<n-1; i++)
{
    if (ints[i+1] > ints[i] && ints[i+1] > ints[i+2])
    {
        cnt++;
    }
}
System.Console.Write(cnt);