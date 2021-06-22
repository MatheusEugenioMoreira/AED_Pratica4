using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class MaxMin
    {

        // Operação relevante: TESTES (if)
        // T(n) = 2n - 2
        public void maxMin1(int[] vet)
        {
            int ma, me;
            int i, cont = 0;
            ma = me = vet[0];
            for (i = 1; i < vet.Length; i++)
            {
                cont++;
                if (vet[i] < me)
                    me = vet[i];
                cont++;
                if (vet[i] > ma)
                    ma = vet[i];
            }
            Console.Write(cont);
        }

        // Melhor caso: T(n) = n - 1
        // Pior caso: T(n) = 2n - 2
        // Caso médio: T(n) = 3n/2 - 3/2
        public void maxMin2(int[] vet)
        {
            int ma, me, cont = 0;
            int i;
            ma = me = vet[0];
            for (i = 1; i < vet.Length; i++)
            {
                cont++;
                if (vet[i] < me)
                    me = vet[i];

                else
                {
                    cont++;
                    if (vet[i] > ma)
                        ma = vet[i];
                }
            }
            Console.Write(cont);
        }

        // T(n) = 3n/2 - 2
        public void maxMin3(int[] vet)
        {
            int ma, me;
            int i, cont = 0;

            cont++;
            if (vet[0] < vet[1])
            {
                me = vet[0];
                ma = vet[1];
            }
            else
            {
                me = vet[1];
                ma = vet[0];
            }
            for (i = 2; i < vet.Length; i += 2)
            {
                cont++;
                if (vet[i] < vet[i + 1])
                {
                    cont++;
                    if (vet[i] < me)
                        me = vet[i];

                    cont++;
                    if (vet[i + 1] > ma)
                        ma = vet[i + 1];
                }
                else
                {
                    cont++;
                    if (vet[i + 1] < me)
                        me = vet[i + 1];

                    cont++;
                    if (vet[i] > ma)
                        ma = vet[i];
                }
            }
            Console.Write(cont);
        }
    }
}
