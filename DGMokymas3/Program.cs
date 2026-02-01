namespace DGMokymas3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NaujaFunkcija();
            //NaujaFunkcija();
            //NaujaFunkcija();
            //NaujaFunkcija();
            //SkaiciausFunkcija();
            //skaicius = skaicius + 3;
            //int grazinamasSkaicius = SkaiciausFunkcijaGrazinimas();
            //Console.WriteLine(SkaiciausFunkcijaGrazinimas() + 10);
            //skaicius = 7;

            //Console.WriteLine(Suma(9,12));
            //Console.WriteLine(Suma(15,35));
            //Console.WriteLine(PilnasVardas("Justas","Justaitis"));
            //Console.WriteLine(GeneruotiSkaicius(30));
            //List<int> manoSkaiciai = GeneruotiSkaicius(20);
            //SpausdintiSkaicius(manoSkaiciai);
            List<int> testas = new List<int>();
            testas.Add(4);
            Console.WriteLine(testas);

        }
        static List<int> GeneruotiSkaicius(int kiekis)
        {
            List<int> skaiciai = new List<int>();

            for (int i = 0; i < kiekis; i++)
            {
                skaiciai.Add(i);
            }
            return skaiciai;
        }

        static void SpausdintiSkaicius(List<int> skaiciai)
        {
            foreach (int skaicius in skaiciai) // int skaicius = skaiciai[0];
            {
                Console.WriteLine(skaicius);
            }
        }
        static void NaujaFunkcija()
        {
            Console.WriteLine("Funkcija veikia");
        }

        static void SkaiciausFunkcija()
        {
            int skaicius = 5;
            Console.WriteLine(skaicius);
        }
        static int SkaiciausFunkcijaGrazinimas()
        {
            int skaicius = 5;
            return skaicius;
        }
        static int Suma(int sk1, int sk2) // sk1 yra parametras | sk1 = 9
        {
            int skaicius = sk1 + sk2;
            return skaicius;
        }

        static string PilnasVardas(string vardas, string pavarde)
        {
            return vardas + " " + pavarde;
        }

    }
}
