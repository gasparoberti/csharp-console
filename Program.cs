using System;
using  System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Holi");
            
            decimal d = 0.10000m;
            // while (d != 0m)
            // {
                Console.WriteLine(d);
                d = d/1m;
            // }
            

            // List<int> l = new List<int>();
            // l.Add(0);
            // l.Add(0);
            // l.Add(1);
            // l.Add(0);
            // l.Add(0);
            // l.Add(1);
            // l.Add(0);

            // Console.WriteLine("Lista: " + printList(l));
            // Console.WriteLine("Elementos: " + l.Count.ToString());
            
            // int s1=0;
            // int s2=0;
            
            // //cuando cuenta siempre de a uno
            // for (int i = 0; i < l.Count-1; i++)
            // {
            //     if(l[i+1]==0) {
            //         s1+=1;
            //     } 
            // }

            // //cuando considera saltos dobles
            // for (int i = 0; i < l.Count-1; i++)
            // {
            //     if(l[i+1]==0 && l[i+2]==0) {
            //         s2+=1;
            //         i+=2;
            //     } 
            // }

            // int s=0;
            // if(s1<s2) {
            //     s=s1;
            // }
            // else {
            //     s=s2;
            // }
        }

        
        // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        decimal sp=0.000000m;
        decimal sn=0.000000m;
        decimal sz=0.000000m;
        // cuento los pos, neg y ceros
        for (int i=0; i<arr.Length; i++) {
            if (arr[i]>0) {
                sp++;
            } else if (arr[i]<0) {
                    sn++;
                } else {
                    sz++;
                }
            
        }  
        
        decimal s= 0.000000m;
        s+=Convert.ToDecimal(arr.Length);
        
        decimal ssp = 0.000000m + sp/s;
        Console.WriteLine(Decimal.Round(ssp, 6));
        
        decimal ssn = 0.000000m + sn/s;
        Console.WriteLine(Decimal.Round(ssn, 6));
        
        decimal ssz = 0.000000m + sz/s;
        Console.WriteLine(Decimal.Round(ssz, 6));
        
        return;
    }
        
        // calcula la resta (valor absoluto) entre la sumatoria de los elementos de la diag principal menos la sumatoria de los elementos de la diagonal secundaria.
        public static int diagonalDifference(List<List<int>> arr)
    {
        int d1=0; int d2=0;
        for (int i=0; i<arr.Count; i++) {
            d1+=arr[i][i];
            // Console.WriteLine(arr[i][i]);
        }
        
        int n=arr.Count-1; int m=0;
        while(n>=0 && m<arr.Count) {
            d2+=arr[m][n];
            Console.WriteLine(arr[m][n]);
            
            n--; m++;
        }
            
        // Console.WriteLine(d1);
        // Console.WriteLine(d2);
        
        return Math.Abs(d1-d2);
    }

        //retorna un string con los valores de una lista: "[1 2 3]" 
        // Console.WriteLine(printList(l));
        static String printList(List<int> l){
            String list="[";
            for (int i = 0; i < l.Count; i++)
            {
                list+= l[i];
                if(i+1 != l.Count){
                    list+= " ";
                }
            }

            list+="]";

            return list;
        }

        //cuenta cuántas ocurrencias de numero hay en la lista l
        // Console.WriteLine(buscar(l,1));
        static int contar(List<int> l, int numero){
            int n=0;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i]==numero)
                {
                    n+=1;
                }
            }

            return n;
        }

        //bueca si existe numero en la lista l
        static Boolean buscar(List<int> l, int numero){
            Boolean f=false;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i]==numero)
                {
                    f=true;
                }
            }

            return f;
        }
    }
}
