using System;

class Program
{
    public static void Main(string[] args)
    {
        long numero = 0;
        Console.WriteLine("digite o numero do cartao");
        numero = long.Parse(Console.ReadLine());

        long a = numero % 10;
        long b = ((numero % 100) / 10);
        long c = ((numero % 1000) / 100);
        long d = ((numero % 10000) / 1000);

        long e = ((numero % 100000) / 10000);
        long f = ((numero % 1000000) / 100000);
        long g = ((numero % 10000000) / 1000000);
        long h = ((numero % 100000000) / 10000000);

        long i = ((numero % 1000000000) / 100000000);
        long j = ((numero % 10000000000) / 1000000000);
        long k = ((numero % 100000000000) / 10000000000);
        long l = ((numero % 1000000000000) / 100000000000);

        long m = ((numero % 10000000000000) / 1000000000000);
        long n = ((numero % 100000000000000) / 10000000000000);
        long o = ((numero % 1000000000000000) / 100000000000000);
        long p = (numero / 1000000000000000);

        int aa = (((int)b * 2) % 10);
        int ab = ((((int)b * 2) % 100) / 10);

        int ac = (((int)d * 2) % 10);
        int ad = ((((int)d * 2) % 100) / 10);

        int ae = (((int) f * 2) % 10);
        int af = ((((int) f * 2) % 100) / 10);

        int ag = (((int) h * 2) % 10);
        int ah = ((((int) h * 2) % 100) / 10);

        int ai = (((int) j * 2) % 10);
        int aj = ((((int) j * 2) % 100) / 10);

        int ak = (((int) l * 2) % 10);
        int al = ((((int) l * 2) % 100) / 10);

        int am = (((int) n * 2) % 10);
        int an = ((((int) n * 2) % 100) / 10);

        int ao = (((int) p * 2) % 10);
        int ap = ((((int) p * 2) % 100) / 10);

        int z = (aa + ab + ac + ad + ae + af + ag + ah + ai + aj + ak + al + am + an + ao + ap);
        int zz = (int) (z + a + c + e + g + i + k + m + o);
        bool valid = ((zz % 10) == 0);
        bool invalid = ((zz % 10) != 0);

        if (valid)
        {
            Console.WriteLine("Valid");
            do
            {
                if (o == 3 && ((n == 4) || (n == 7)))
                {
                    Console.WriteLine("amex");
                }
                else if (p == 5 && ((o == 1) || (o == 2) || (o == 3) || (o == 4) || (o == 5)))
                {
                    Console.WriteLine("mastercard");
                }
                else if (p == 4 || (m == 4 && p != 4 && p != 5))
                {
                    Console.WriteLine("visa");
                }
            }
            while (invalid);
        }
        else if ((zz % 10) != 0)
        {
            Console.WriteLine("invalid");
        }
    }
}