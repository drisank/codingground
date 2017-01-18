using System.IO;
using System;

class Program
{
    static void Main()
    {
        int n,i,db,db_ossz;
        db_ossz = 1;
        Console.WriteLine("Melyik számot bontsuk fel?");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Prímtényezős felbontás:  ");
        for (i = 2; i<=n; i++)
        {
            if (n % i == 0 )
            {
                db = 1;
                while (n % i == 0)
                {
                    Console.Write("{0}",i);
                    n = n/i;
                    db++;
                    if (n != 1)
                    {
                        Console.Write(" * ");
                    }
                }
                db_ossz = db_ossz * (db + 1);
            }
        }
        Console.WriteLine("\nOsztók száma: {0}\n", db_ossz);
    }
}
