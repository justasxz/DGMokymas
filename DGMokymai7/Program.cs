namespace DGMokymai7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int? skaicius = null;

            //Console.WriteLine(skaicius);
            //// pasiimk is duomenu bazes zmogu vardu Jonas
            ////Human? paiimtasZmogus = database.get("Vardas==Jonas") // metu klaida nes, o kas jeigu netycia nerasiu ? 
            //if paiimtasZmogus != null
            //    {

            //}
            // Linq
            var ints = new List<double>()
            {
                4,9,5,2,1,6,6,4,6,489,79,89,7948,65,65,65,65,89,789,46,554,665,65,46
            };
            //var mano = "Labas";

            //var tavo = 5;

            //var zodynas = new Dictionary<string, List<int>>();
            //var nezinomas = ints.Any();
            //if (ints.Any())
            //{

            //}

            //var nezinomas = ints.Where(Patikra);
            var nezinomas = ints.Take(3).Skip(2).Take(2);
            //var nezinomas = ints.Where(x => x > 50); //rodykline funkcija/anonimine/lambda
            foreach (var skaicius in nezinomas)
            {
                Console.WriteLine(skaicius);
            }
            var something = Tuple.Create(5, "Labas", 7.9);

        }
        public static bool Patikra(double x)
        {
            if (x > 50)
            {
                return true;
            }
            return false;
        }
        //public static double Kvadratu(int x)
        //{
        //    return Math.Pow(x, 2);
        //}
        // class Object -> ToString() { return "this project_name + this class_name }
    }

    //class Dog
    //{
    //    public var Vardas { get; set; }
    //}

}