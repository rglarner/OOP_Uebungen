namespace MiniCLI
{
    internal class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
                return 2; // Argumentfehler
            }

            // Standardwerte
            bool upper = false, lower = false;
            int repeat = 1;
            string? text = null;

            // Loop durch die Argumente
            for (int i = 0; i < args.Length; i++)
            {
                string a = args[i];

                switch (a)
                {
                    case "-h":
                    case "--help":
                        PrintUsage();
                        return 0;

                    case "-u":
                    case "--upper":
                        upper = true;
                        break;

                    case "-l":
                    case "--lower":
                        lower = true;
                        break;

                    case "-r":
                    case "--repeat":
                        if (i + 1 >= args.Length || args[i + 1].StartsWith("-"))  // Nächster Parameter fehlt oder ist eine Flag
                        {
                            return Error("Fehler: Wert für -r/--repeat fehlt.");
                        }
                        if (!int.TryParse(args[++i], out repeat) || repeat < 1)  // Anzahl ist keine gültige Zahl oder kleiner 1
                        {
                            return Error("Fehler: Wiederholungen N muss eine ganze Zahl ≥ 1 sein.");
                        }
                        break;

                    default:
                        // erster nicht-Flag-Parameter = Text; zusätzliche Teile anhängen
                        // (falls ohne Anführungszeichen übergeben)
                        if (text == null)
                        {
                            text = a;
                        }
                        else
                        {
                            text = text + " " + a;
                        }
                        break;
                }
            }

            if (text is null)
                return Error("Fehler: Pflichtargument <text> fehlt.");

            if (upper && lower)
                return Error("Fehler: --upper und --lower dürfen nicht gleichzeitig verwendet werden.");

            string output = upper ? text.ToUpper() : lower ? text.ToLower() : text;

            for (int i = 0; i < repeat; i++)
                Console.WriteLine(output);

            return 0;
        }
        static void PrintUsage()
        {
            Console.WriteLine("Usage: app [-h|--help] [-u|--upper|-l|--lower] [-r N|--repeat N] <text>");
            Console.WriteLine("Beispiele:");
            Console.WriteLine("  app \"Hallo Welt\"");
            Console.WriteLine("  app -u -r 3 \"Hallo\"");
            Console.WriteLine("  app --lower \"Schön\"");
        }

        static int Error(string msg)
        {
            Console.Error.WriteLine(msg);
            PrintUsage();
            return 2;
        }
    }
}
