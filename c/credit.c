#include <stdio.h>
#include <cs50.h>
#include <math.h>

int main(void)
{
    long (numero);
    numero = get_long ("Numero do cartão: ");

    long a = numero % 10;
    long b = ((numero % 100)/10);
    long c = ((numero % 1000)/100);
    long d = ((numero % 10000)/1000);

    long e = ((numero % 100000)/10000);
    long f = ((numero % 1000000)/100000);
    long g = ((numero % 10000000)/1000000);
    long h = ((numero % 100000000)/10000000);

    long i = ((numero % 1000000000)/100000000);
    long j = ((numero % 10000000000)/1000000000);
    long k = ((numero % 100000000000)/10000000000);
    long l = ((numero % 1000000000000)/100000000000);

    long m = ((numero % 10000000000000)/1000000000000);
    long n = ((numero % 100000000000000)/10000000000000);
    long o = ((numero % 1000000000000000)/100000000000000);
    long p = ((numero % 10000000000000000)/1000000000000000);

    int aa = ((b*2) % 10);
    int ab = (((b*2) % 100)/10);

    int ac = ((d*2) % 10);
    int ad = (((d*2) % 100)/10);

    int ae = ((f*2) % 10);
    int af = (((f*2) % 100)/10);

    int ag = ((h*2) % 10);
    int ah = (((h*2) % 100)/10);

    int ai = ((j*2) % 10);
    int aj = (((j*2) % 100)/10);

    int ak = ((l*2) % 10);
    int al = (((l*2) % 100)/10);

    int am = ((n*2) % 10);
    int an = (((n*2) % 100)/10);

    int ao = ((p*2) % 10);
    int ap = (((p*2) % 100)/10);

    int z = (aa + ab + ac + ad + ae + af + ag+ ah + ai + aj + ak + al + am + an + ao + ap);
    int zz = (z + a + c + e + g + i + k + m + o);
    int valid = ((zz % 10) == 0);
    int invalid = ((zz % 10) != 0);

    if (valid == true)
    {
        printf ("Valid\n");
        do
        {
            if (o == 3 && ((n == 4) || (n == 7)))
            {
                printf ("amex\n");
            }
            else if (p == 5 && ((o == 1) || (o == 2) || (o == 3) || (o == 4) || (o == 5)))
            {
                printf ("mastercard\n");
            }
            else if (p == 4 || (m == 4 && p != 4 && p != 5))
            {
                printf ("visa\n");
            }
        }
        while (invalid);
    }
    else if ((zz % 10) != 0)
    {
        printf ("invalid\n");
    }
}