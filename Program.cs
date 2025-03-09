internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kode = new KodePos();

        Console.WriteLine("Kelurahan ---- Kode Pos");
        Console.WriteLine("Batununggal " + kode.getKodePos("Batununggal"));
        Console.WriteLine("Kujangsari " + kode.getKodePos("Kujangsari"));
        Console.WriteLine("Mengger " + kode.getKodePos("Mengger"));
        Console.WriteLine("Wates " + kode.getKodePos("Wates"));
        Console.WriteLine("Cijaura " + kode.getKodePos("Cijaura"));
        Console.WriteLine("Jatisari " + kode.getKodePos("Jatisari"));
        Console.WriteLine("Margasari " + kode.getKodePos("Margasari"));
        Console.WriteLine("Sekejati " + kode.getKodePos("Sekejati"));
        Console.WriteLine("Kebonwaru " + kode.getKodePos("Kebonwaru"));
        Console.WriteLine("Maleer " + kode.getKodePos("Maleer"));
        Console.WriteLine("Samoja " + kode.getKodePos("Samoja"));

        Console.WriteLine("State based");
        DoorMachine door = new DoorMachine();
        door.buka();
        door.buka();
        door.kunci();
        door.kunci();
        door.buka();
        door.buka();
    }
}