using System;

public class Program
{
    public static int silnia(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else if(n == 1)
        {
            return 1;
        }
        else
        {
            return n * silnia(n - 1);
        }
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int wynik = 1;
        int liczba = 1;
        
        int[][] tab = new int[n][];
        for (int i = 0; i < n; i++)
        {
            liczba = int.Parse(Console.ReadLine());
            tab[i] = new int[2];
            if (liczba > 9)
            {
                tab[i][0] = 0;
                tab[i][1] = 0;
            }
            else
            {
                int wynik = silnia(liczba);
                if ((wynik < 10))
                {
                    tab[i][0] = 0;
                    tab[i][1] = wynik;

                }
                else if ((wynik < 100))
                {

                    tab[i][0] = wynik / 10;
                    //Console.Write(tmp + " ");
                    tab[i][1] = wynik % 10;
                    
                    //Console.Write(tmp);
                }
                else if ((wynik < 1000))
                {

                    tab[i][0] =  (wynik % 100) / 10; // jednosci
                    //Console.Write(tmp + " ");
                    tab[i][1] =   ((wynik / 100) / 10); // dziesietne
                    //Console.Write(tmp);
                }
                else if (wynik < 10000)
                {

                    tab[i][0] =   (wynik % 100) / 10;
                    //Console.Write(tmp + " ");
                    tab[i][1] =   ((wynik % 100) % 10);
                    //Console.Write(tmp);
                }
                else if ((wynik < 100000))
                {

                    tab[i][0] =   (((wynik % 1000) / 10) % 10);
                    //Console.Write(tmp + " ");
                    tab[i][1] =  ((wynik % 1000) % 10);
                    //Console.Write(tmp);
                }
                else if ((wynik < 1000000))
                {
                    tab[i][0] = (((wynik % 10000) % 100)) / 10;
                    tab[i][1] = ((wynik % 1000) % 10);
                }

            }

        }

        for(int i = 0; i < n; i++)
        {
            int j = 0;
            Console.WriteLine(tab[i][j] + " " + tab[i][j + 1]);
            
        }
    }
}
