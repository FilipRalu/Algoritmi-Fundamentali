using System;

namespace _511
{
    class Program
    {
        static void Main(string[] args)
        {
                int n, k;
                string[] data2 = Console.ReadLine().Split(' ');

                n = int.Parse(data2[0]);
                k = int.Parse(data2[1]);

                int[] v = new int[n];
                string[] data = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(data[i]);
                }
                for (int i = 0; i < k - 1; i++)
                    for (int j = i + 1; j < k; j++)
                        if (v[i] > v[j])
                        {
                            int aux = v[i];
                            v[i] = v[j];
                            v[j] = aux;
                        }
                for (int i = k; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (v[i] < v[j])
                        {
                            int aux = v[i];
                            v[i] = v[j];
                            v[j] = aux;
                        }
                for (int i = 0; i < n; i++)
                    Console.Write(v[i] + " ");
            }
        }
    }
