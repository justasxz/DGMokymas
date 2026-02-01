using DGMokymas5;

namespace DGMokymas4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int value = 7;

            //ValueTipas(value);
            //Console.WriteLine(value);
            //List<int> skaiciai = new List<int>();
            //skaiciai.Add(1);
            //skaiciai.Add(2);

            //skaiciai.Add(3);

            //ReferenceTipas(skaiciai);

            //foreach (int i in skaiciai)
            //{
            //    Console.WriteLine(i);
            //}
            //int akcija = 0;
            ////string az = "";
            //double grazintaKaina = PritaikytiAkcija(10, ref akcija, out string az); // nuo siol mes nedarysime kopijos, o dirbsime su originalu metode sitame
            //Console.WriteLine($"Nauja kaina: {grazintaKaina} o akcija {akcija}, o zodziai {az}");

            //string skaiciusTekstu = "labas";
            //Console.WriteLine($"Ar tiesa, kad kintamasis yra konvertuotinas:  {int.TryParse(skaiciusTekstu, out int konvertuotas)}  ");
            //Console.WriteLine("O konvertuotas skaicius yra: " + konvertuotas);

            //if (int.TryParse(skaiciusTekstu, out konvertuotas))
            //{
            //    Console.WriteLine("Konvertuotas sekmingai");
            //}
            //else
            //{
            //    Console.WriteLine("nepavyko nes nebuvo skaicius");
            //}
            // tiek ref tiek out, keiciasi i reference tipa taciau ref sako, kad as tau duodu egzistuojanti kintamaji ir tu gali ji pakeisti arba ne
            // out sako, as tau duodu galbut egzistuojant arba neegzistuojanti kintamaji ir tu privalai visais atvejais metodo, suteikti jam reiksme, kad netycia nebutu null

            //PakeistiSarasa(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });

            //File.WriteAllText("naujas.txt", "Sveiki, kaip sekasi ?"); // jeigu nera failo ji sukuria, o jeigu yra istrina visa jo turini ir iraso kas pasakyta
            //File.AppendAllText("naujas.txt", $"Kaip reikaliukai ?"); // jis neistrina, bet jeigu failo nera ji sukuria
            //File.AppendAllLines("naujas.txt", new List<string> { "Cia yra apendas", "Viskas apende vyksta", "Paziurekime, kaip veikia apendas" });
            //if (File.Exists("naujas.txt"))
            //{
            //    var tekstas = File.ReadAllLines("naujas.txt");// sarasa kur kiekvienas elements yra failo eilute
            //    //string tekstas = File.ReadAllText("naujas.txt"); // grazina visa teksta
            //    Console.WriteLine(tekstas);
            //    foreach (var eilute in tekstas)
            //    {
            //        Console.WriteLine(eilute);
            //    }
            //}

            
            Console.WriteLine(Path.Combine("C:\\Users\\guiku\\source\\repos\\DGMokymas1\\DGMokymas4\\bin", "mano\\aplankas\\tavo", "naujas.txt"));
            Console.WriteLine(Path.GetFullPath("naujas.txt"));  
            //Path
            //Directory.
            //Environment

            // relative vs global path

            //Car auto1 = new Car();

        }

        //static void spausdintiSarasa(List<int> ints)
        //{
        //    foreach (int i in ints)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //static void PakeistiSarasa(List<int> ints)
        //{
        //    ints.Add(1);
        //    spausdintiSarasa(ints);
        //}


        //static void ValueTipas(int value)
        //{
        //    value = value + 15;
        //}
        //static void ReferenceTipas(List<int> reference)
        //{
        //    reference.Add(4);
        //}


        //static double PritaikytiAkcija(double kaina, ref int testas, out string akcijaZodziais)
        //{
        //    //testas = 0;

        //    double naujaKaina = kaina;
        //    // grazinti nauja kaina ir pritaikyta akcija
        //    if (kaina > 20 && kaina < 80)
        //    {
        //        // akcija yra 10%
        //        naujaKaina = naujaKaina * 0.9;
        //        testas = 10;
        //        akcijaZodziais = "Nedidele";

        //    }
        //    else if (kaina > 80 && kaina <= 200)
        //    {
        //        // akcija bus 20
        //        naujaKaina = naujaKaina * 0.8;
        //        testas = 20;
        //        akcijaZodziais = "Didele";
        //    }
        //    else
        //    {
        //        //akcijos nera
        //        akcijaZodziais = "Akcijos nera";
        //        //testas = 0;
        //    }
        //    return naujaKaina;

        //}


    }
}
