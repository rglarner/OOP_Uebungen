namespace Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Ticket("Erstes Ticket");
            var b = new Ticket("Zweites Ticket");
            var c = new Ticket("Drittes Ticket");

            Console.WriteLine($"{a.Titel}: Id={a.Id}"); // 1
            Console.WriteLine($"{b.Titel}: Id={b.Id}"); // 2
            Console.WriteLine($"{c.Titel}: Id={c.Id}"); // 3
        }
    }
}
