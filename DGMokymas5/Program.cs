namespace DGMokymas5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Car auto = new Car();

            //auto.Year = 2020;
            //auto.Make = "Toyota";
            //auto.Model = "Corolla";

            //Console.WriteLine(auto.Make);

            //Car auto2 = new Car();
            //auto2.Year = 2021;
            //auto2.Make = "Honda";
            //auto2.Model = "Civic";
            //Console.WriteLine(auto2.Make);

            //auto2.Year = 2019;
            //Console.WriteLine(auto2.Year);


            //Car auto = new Car("Toyota","Camry");
            //Console.WriteLine(auto.Year);
            //Car auto2 = new Car("Toyota", "Corolla");
            //Console.WriteLine(auto2.Make);
            //Car auto3 = new Car("Honda", 2022);

            //auto3.Model = "Civic";

            //auto2.Uzsikurti();
            //Car auto4 = new Car();
            //auto4.Make = "Nissan"; // private, reiskia, kad jis gali buti set (nustatytas) tik konstruktoriuje arba klases viduje

            //List<int> list = new List<int>();
            //list.Count = 7; // Count yra tik skaitomas, todel negalima nustatyti reiksmes is isores
            //Console.WriteLine(list.Count);


            Car auto = new Car("Toyota", "Camry");
            Console.WriteLine(auto.Year);
            Car auto2 = new Car("Toyota", "Corolla");
            Console.WriteLine(auto2.Make);
            Car auto3 = new Car("Honda", 2022);

            auto3.Model = "Civic";

            auto2.Uzsikurti(true);
            //AtspausdintiAutomobili(auto3);
            auto3.ParodytiDuomenis();
            //Car.ParodytiDuomenis();
            //Car.Statusas();
            //Program pavadinimas = new Program();
            //pavadinimas.AtspausdintiAutomobili();
            //AtspausdintiAutomobili(auto);

            //ParodytiDuomenis();
            // static metodai gali buti pasiekiami be klases objekto sukurimo
            // ne static metodai gali buti pasiekiami tik sukurius klases objekta
            // static naudojame tada kai metodas nepriklauso konkreciai klasei, o yra bendras visiems
            // ne static naudojame tada kai metodas priklauso konkreciai klasei ir dirba su tos klases duomenimis

        }

        void AtspausdintiAutomobili(Car car)
        {
            Console.WriteLine($"Automobilis: {car.Make} {car.Model} {car.Year}");
        }

    }
    // private reiskia, galima pasiekti tik klases viduje
    // public galima pasiekti is isores is bet kur)
    // internal - galima pasiekti tik tame paciame assembly (projekte)
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public void Uzsikurti(bool batExists) // metodas (jis gali tureti bet kiek, bet koki pavadinima, bet kokius kintamuosius ir gali grazinti reiksme arba ne)
        {
            if (!batExists)
            {
                Console.WriteLine("Negalima uzsikurti, nes baterija issekusi");
            }
            else
            {
                Console.WriteLine($"Automobilis {Make} {Model} uzsikure");
            }
        }

        public void ParodytiDuomenis()
        {
            Console.WriteLine($"Automobilis: {Make} {Model} {Year}");
        }
/*        public static void Statusas()
        {
            Console.WriteLine($"Veikiu puikiai {Make}");
        }*/


        public Car(string make, int year) // constructor turi ta pati pavadinima kaip ir klase
        {
            Make = make;
            Year = year;
            Console.WriteLine("AUtomobilis sukurtas su metais");
        }
        public Car()
        {

        }

        public Car(string make, string model) // constructor turi ta pati pavadinima kaip ir klase
        {
            Make = make;
            Model = model;
            Year = DateTime.Now.Year;
            Console.WriteLine("AUtomobilis sukurtas be metu");
        }

    }


}
