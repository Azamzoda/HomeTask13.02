
int n= Convert.ToInt32(Console.ReadLine());

int[] ints = new int[n];
for (int i=0; i<n; i++)
{
    ints[i] = Convert.ToInt32(Console.ReadLine());
}

int cnt = Convert.ToInt32(0);


for (int i=0; i<n; i++)
{
    for (int j=0; j<n; j++)
    {
        if(ints[i] == ints[j] && i!=j)
        {
            cnt++;
            break;
        }       
    }
     
     if (cnt == 0)
     {
         System.Console.Write(ints[i]+" ");
     }
        cnt=0;
}