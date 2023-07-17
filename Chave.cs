using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Chave
    {
        public static void Ler(int n, int[] ch)
        {
            //ler o n sem que leia números repetidos
            for(int i = 0; i < n; i++)
            {
                bool repetido = false;

                do
                {
                    Console.Write("Qual o elemento " + i + "? ");
                    ch[i] = Convert.ToInt32(Console.ReadLine());

                    for (int k = 0; k < i; k++)
                    {
                        if (k == i)
                        {

                        }
                    }
                } while (repetido);
            }
        }

        public static void Ordenar(int n, int[] ch)
        {
            Array.Sort(ch);
            foreach (int i in ch) Console.Write(i + " ");

            //for(int i = 0; i < n-1; i ++)
            //{
            //  for(int j = i+1; j < n; j++)
            //  {
            //      if(ch[i] > ch[j])
            //      {
            //          aux = ch[i]
            //          ch[i] = ch[j]
            //          ch[j] = aux 
            //      }
            //  }
            //}

            Console.WriteLine();
        }
        public static void Mostrar(int n, int[] ch)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(ch[i] + " ");
            }
            Console.WriteLine();
        }

        public static void LerRand(int n, int[] ch)
        {
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                bool repetido = false;
                do
                {
                    ch[i] = r.Next(1, 51);
                    for(int k = 0; k < i; k++)
                    {
                        if (ch[i] == ch[k])
                        {
                            repetido = true;
                        }
                    }
                }while(repetido);
            }
        }

        public static void Acertados(int n, int[] ch)
        {
            int cont = 0;
            for(int i = 0; i < n; i++)
            {
                int iguais = 0;
                for(int x = 0; x < n; x++)
                {
                    if(ch[i] == ch[x])
                    {
                        cont++;
                        break;
                    }
                }
                Console.Write(iguais + " ");
            }
        }
    }
}
