namespace ejercicio7
{
    public class leche
    {

        public static void Main()
        {
            double lpg = 3.785;
            double LV, PG, CG, VV;

            Console.WriteLine("por favor digite los litros de la venta");
            LV = double.Parse(Console.ReadLine());

            Console.WriteLine("por favor digite el precio del galon");
            PG = double.Parse(Console.ReadLine());
            CG = LV / lpg;
            VV = CG * PG;
            Console.WriteLine($"el valor venta es {VV}");
            Console.WriteLine($"cantidad de galones {CG}");
        }
    }
}