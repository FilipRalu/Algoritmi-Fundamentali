using System;

namespace _510
{
    class Program
    {
        static bool prim(int v)
        {
            if (v < 2)
                return false;
            else
                if (v == 2)
                return true;
            else
                if (v%2==0)
                return false;
            else
            {
                for (int i = 3; i * i <= v; i += 2)
                    if (v % i == 0)
                        return false;
            }
            return true;

        }
        static void Main(string[] args)
        {
            int i,j,n,k=0,aux=0;
            int[] v;
            n = int.Parse(Console.ReadLine());
            v = new int[n];
            string[] data = Console.ReadLine().Split(' ');
            for(i=0;i<n;i++)
            {
                if (prim(int.Parse(data[i])))
                {
                    v[k] = int.Parse(data[i]);
                    k++;
                }
            }
            for(i=0;i<k-1;i++)
            { 
                for(j=i+1;j<k;j++)
                    if(v[i]>v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            }
            for(i=0;i<k;i++)
                Console.Write(v[i]+" ");
        }
                
    }
}
